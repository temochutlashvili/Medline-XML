using Opulos.Core.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace XMLEditor
{

    public class ArticleSet
    {

        Accordion _accordion;

        public ArticleSet()
        {

        }

        public ArticleSet(Accordion accordion)
        {
            this._accordion = accordion;
        }

        [XmlElement("Article")]
        public List<Article> _articles = new List<Article>();

        public string toString()
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            var stringwriter = new System.IO.StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stringwriter, new XmlWriterSettings { Indent = true }))
            {
                writer.WriteDocType("ArticleSet", "-//NLM//DTD PubMed 2.8//EN", "https://dtd.nlm.nih.gov/ncbi/pubmed/in/PubMed.dtd", null);
                var serializer = new XmlSerializer(typeof(ArticleSet));
                serializer.Serialize(writer, this, ns);
            }

            return stringwriter.ToString();
        }

        public void addAricle(Article article)
        {
            _articles.Add(article);
            article.articeEvent += article_Action;
            article.addTitleEvents();
            CheckBox cb = _accordion.Add(article.getItem().getControl(), article.composeTitle(), article.composeTitle(), 0, false);
            cb.BackColor = article.getStateColor();
        }

        public void setAccordion(Accordion accordion)
        {
            _accordion = accordion;
        }

        public void rebuildAccordion()
        {
            _accordion.Controls.Clear();
            foreach(Article article in _articles)
            {
                CheckBox cb =_accordion.Add(article.getItem().getControl(), article.composeTitle(), article.composeTitle(), 0, false);
                cb.BackColor = article.getStateColor();
                article.addTitleEvents();
                article.rebuildAuthors();
            }
        }

        void article_Action(object sender, ArticleEventArgs ea)
        {
            switch (ea.type)
            {
                case Article.ArticleEventType.delete:
                    deleteArticle(sender as Article);
                    break;
                case Article.ArticleEventType.up:
                    moveArticleUp(sender as Article);
                    break;
                case Article.ArticleEventType.down:
                    moveArticleDown(sender as Article);
                    break;
            }
        }

        private void deleteArticle(Article article)
        {
            article.articeEvent -= article_Action;
            _accordion.Clear();
            _articles.Remove(article);
            rebuildAccordion();
        }

        private void moveArticleUp(Article article)
        {
            var index = _articles.IndexOf(article);
            if (index > 0)
            {
                _articles.Remove(article);
                _articles.Insert(--index, article);
            }
            _accordion.Clear();
            rebuildAccordion();
        }

        private void moveArticleDown(Article article)
        {
            var index = _articles.IndexOf(article);
            if (index < _articles.Count - 1)
            {
                _articles.Remove(article);
                _articles.Insert(++index, article);
            }
            _accordion.Clear();
            rebuildAccordion();
        }

    }

}
