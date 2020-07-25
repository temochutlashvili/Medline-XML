using Opulos.Core.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XMLEditor
{
    [Serializable]
    public class Article
    {
        TextBox _articleTitle = new TextBox { };
        string _firstPage = "";
        string _lastPage = "";
        string _language = "";
        string _abstract = "";

        AccordionItem _accordionItem;

        [XmlElement("Journal")]
        public Journal journal;

        [XmlArray("AuthorList")]
        public List<Author> _authors;

        [XmlElement]
        public string ArticleTitle
        {
            get
            {
                return _articleTitle.Text;
            }

            set
            {
                _articleTitle.Text = value;
            }
        }

        [XmlElement]
        public string FirstPage
        {
            get
            {
                return _firstPage;
            }

            set
            {
                _firstPage = value;
            }
        }

        [XmlElement]
        public string LastPage
        {
            get
            {
                return _lastPage;
            }

            set
            {
                _lastPage = value;
            }
        }

        [XmlElement]
        public string Language
        {
            get
            {
                return _language;
            }

            set
            {
                _language = value;
            }
        }

        [XmlElement]
        public string Abstract
        {
            get
            {
                return _abstract;
            }

            set
            {
                _abstract = value;
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
            _accordionItem = new AccordionItem();
            _accordionItem.TopLevel = false;
            addAddAuthorEvent();
            journal = new Journal();
            _authors = new List<Author>();
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
        }

        public void moveAuthorDown(Author author)
        {
            var index = _authors.IndexOf(author);
            if(index < _authors.Count - 1)
            {
                _authors.Remove(author);
                _authors.Insert(++index, author);
            }
        }

        public void rebuildAuthors()
        {
            _accordionItem.getAuthorsControl().Controls.Clear();
            foreach (Author author in _authors)
            {
                author.addAuthorControls(this, _accordionItem.getAuthorsControl());
            }
        }
    }
}
