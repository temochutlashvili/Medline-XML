using Opulos.Core.UI;
using System;
using System.Collections.Generic;
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
            _accordion.Add(article.getItem().getControl(), article.ArticleTitle, article.ArticleTitle, 0, false);
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
                _accordion.Add(article.getItem().getControl(), article.ArticleTitle, article.ArticleTitle, 0, false);
                article.rebuildAuthors();
            }
        }

        

    }

}
