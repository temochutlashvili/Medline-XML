using Opulos.Core.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Schema;

namespace XMLEditor
{
    [Serializable]
    public class Article 
        //: IXmlSerializable
    {
        public enum ArticleEventType {
            delete,
            up,
            down
        }

        public delegate void ArticleEvent(object sender, ArticleEventArgs ea);
        public event ArticleEvent articeEvent;

        RichTextBox _articleTitle = new RichTextBox { };

        AccordionItem _accordionItem = new AccordionItem();

        [XmlElement("Journal", Order = 1)]
        public Journal journal;

        [XmlArray("AuthorList", Order = 6)]
        public List<Author> _authors;

        [XmlIgnore]
        private RawText _titleInstance;

        [XmlElement("ArticleTitle", Order = 2)]
        public RawText titleInstance
        {
            get
            {
                _titleInstance.text = ArticleTitleTextBox;
                return _titleInstance;
            }

            set
            {
                _titleInstance = value;
                ArticleTitleTextBox = value.text;
            }
        }

        [XmlIgnore]
        public string ArticleTitleTextBox
        {
            get
            {
                return _accordionItem.getTitle().Text;
            }

            set
            {
                _accordionItem.getTitle().Text = value;
            }
        }

        [XmlElement(Order = 3)]
        public string FirstPage
        {
            get
            {
                return _accordionItem.getFirstPage().Text;
            }

            set
            {
                _accordionItem.getFirstPage().Text = value;
            }
        }

        [XmlElement(Order = 4)]
        public string LastPage
        {
            get
            {
                return _accordionItem.getLastPage().Text;
            }

            set
            {
                _accordionItem.getLastPage().Text = value;
            }
        }

        [XmlElement(Order = 5)]
        public string Language
        {
            get
            {
                return _accordionItem.getLanguage().Text;
            }

            set
            {
                _accordionItem.getLanguage().Text = value;
            }
        }

        [XmlIgnore]
        private RawText _abstractInstance;

        [XmlElement("Abstract", Order = 7)]
        public RawText abstractInstance
        {
            get
            {
                _abstractInstance.text = AbstractTextBox;
                return _abstractInstance;
            }

            set
            {
                _abstractInstance = value;
                AbstractTextBox = value.text;   
            }
        }

        [XmlIgnore]
        public string AbstractTextBox
        {
            get
            {
                return _accordionItem.getAbstract().Text;
            }

            set
            {
                _accordionItem.getAbstract().Text = value;
            }
        }

        internal List<Author> Authors
        {
            get
            {
                return _authors;
            }

            set
            {
                _authors = value;
            }
        }

        public Article()
        {
        }

        public Article(Accordion accordion)
        {
            //_accordionItem = new AccordionItem();
            setHandlers();
            _accordionItem.TopLevel = false;
            addAddAuthorEvent();
            journal = Journal.Instance;
            _authors = new List<Author>();
            _titleInstance = new RawText();
            _abstractInstance = new RawText();
            //_authors.Add(new Author(_accordionItem.getAuthorsControl()));
        }

        public void addAuthor(String lastname, String firstname, String affiliation)
        {
            _authors.Add(new Author(this, _accordionItem.getAuthorsControl(), lastname, firstname, affiliation));
        }

        public void parseAuthors(String authors, String affiliation)
        {
            var authorReg = new Regex(@"(.[^.]*)\s(.[^.]*).,?", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            var matchAuthorCollection = authorReg.Matches(authors);
            foreach (Match matchAuthor in matchAuthorCollection)
            {
                addAuthor(matchAuthor.Groups[1].Value.Trim(), matchAuthor.Groups[2].Value.Trim(), affiliation);
            }
        }

        public void setItem(AccordionItem accordionItem)
        {
            _accordionItem = accordionItem;
            addAddAuthorEvent();
        }

        public AccordionItem getItem()
        {
            if(_accordionItem == null)
            {
                _accordionItem = new AccordionItem();
                _accordionItem.TopLevel = false;
            }
            return _accordionItem;
        }

        public void reHighlight()
        {
            this._accordionItem.getAbstract().textChanged(this, EventArgs.Empty);
            this._accordionItem.getTitle().textChanged(this, EventArgs.Empty);
        }

        public void addTitleEvents()
        {
            _accordionItem.getFirstPage().TextChanged += new EventHandler(composeTitleChanged);
            _accordionItem.getLastPage().TextChanged += new EventHandler(composeTitleChanged);
            _accordionItem.getTitle().TextChanged += new EventHandler(composeTitleChanged);
            _accordionItem.getLanguage().SelectedIndexChanged += new EventHandler(composeTitleChanged);
        }

        private void addAddAuthorEvent()
        {
            Button but = (Button) this._accordionItem.Controls.Find("addAuthorButton", true)[0];
            but.Click += new EventHandler(addAuthorButtonClick);
        }

        public void addAuthorButtonClick(object sender, System.EventArgs e)
        {
            addAuthor("", "", "");
        }

        public void deleteAuthor(Author author)
        {
            _authors.Remove(author);
            author.Dispose();
        }

        public void moveAuthorUp(Author author)
        {
            var index = _authors.IndexOf(author);
            if(index > 0) {
                _authors.Remove(author);
                _authors.Insert(--index, author);
            }
            foreach(Author a in _authors)
            {
                a.getPanel().BringToFront();
            }
        }

        public void moveAuthorDown(Author author)
        {
            var index = _authors.IndexOf(author);
            if(index < _authors.Count - 1)
            {
                _authors.Remove(author);
                _authors.Insert(++index, author);
            }
            foreach (Author a in _authors)
            {
                a.getPanel().SendToBack();
            }
        }

        public void rebuildAuthors()
        {
            _accordionItem.getAuthorsControl().Controls.Clear();
            foreach (Author author in _authors)
            {
                author.addAuthorControls(this, _accordionItem.getAuthorsControl());
                author.reHighlight();
            }
        }

        public void setHandlers()
        {
            this._accordionItem.getDeleteButton().Click += new EventHandler(deleteButtonClick);
            this._accordionItem.getUpButton().Click += new EventHandler(upButtonClick);
            this._accordionItem.getDownButton().Click += new EventHandler(downButtonClick);
            this._accordionItem.getPreviewButton().Click += new EventHandler(previewButtonClick);
        }

        public void OnAction(ArticleEventType action)
        {
            ArticleEvent temp = articeEvent;
            if (temp != null)
            {
                ArticleEventArgs aea = new ArticleEventArgs();
                aea.type = action;
                temp(this, aea);
            }
        }

        private void deleteButtonClick(object sender, System.EventArgs e)
        {
            OnAction(ArticleEventType.delete);
        }

        private void upButtonClick(object sender, System.EventArgs e)
        {
            OnAction(ArticleEventType.up);
        }

        private void downButtonClick(object sender, System.EventArgs e)
        {
            OnAction(ArticleEventType.down);
        }

        private void previewButtonClick(object sender, System.EventArgs e)
        {
            PreviewForm pf = new PreviewForm(this);
            pf.ShowDialog();
        }

        public String composeTitle()
        {
            return FirstPage + " - " + LastPage + " - " + Language + " - " + ArticleTitleTextBox;
        }

        public Color getStateColor()
        {
            if (String.IsNullOrEmpty(FirstPage) || String.IsNullOrEmpty(LastPage) || String.IsNullOrEmpty(Language))
            {
                return System.Drawing.Color.LightPink;
            }
            else
            {
                return SystemColors.Control;
            }
        }

        private void composeTitleChanged(object sender, EventArgs e)
        {
            var acc = (Accordion)_accordionItem.getControl().Parent.Parent;
            var cb = acc.CheckBoxForControl(_accordionItem.getControl());
            cb.Text = composeTitle();
            cb.BackColor = getStateColor();
        }

        public XmlSchema GetSchema()
        {
            return (null);
        }

        public void ReadXml(XmlReader reader)
        {
            
        }

        public void WriteXml(XmlWriter writer)
        {
        }
    }

    public class ArticleEventArgs : EventArgs
    {
        public Article.ArticleEventType type { get; set; }
    }
}
