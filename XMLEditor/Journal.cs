using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLEditor
{
    [Serializable]
    public sealed class Journal
    {
        private static readonly Journal instance = new Journal();

        static string _publisherName = "";
        static string _journalTitle = "Geogian Medical News";
        static string _iSSN = "";
        static string _volume = "";
        static string _issue = "";

        static Journal()
        {

        }

        private Journal()
        {
            pubDate = PubDate.Instance;
        }

        public static Journal Instance
        {
            get
            {
                return instance;
            }
        }

        [XmlElement]
        public string PublisherName
        {
            get
            {
                return _publisherName;
            }

            set
            {
                _publisherName = value;
            }
        }

        [XmlElement]
        public string JournalTitle
        {
            get
            {
                return _journalTitle;
            }

            set
            {
                _journalTitle = value;
            }
        }

        [XmlElement]
        public string ISSN
        {
            get
            {
                return _iSSN;
            }

            set
            {
                _iSSN = value;
            }
        }

        [XmlElement]
        public string Volume
        {
            get
            {
                return _volume;
            }

            set
            {
                _volume = value;
            }
        }

        [XmlElement]
        public string Issue
        {
            get
            {
                return _issue;
            }

            set
            {
                _issue = value;
            }
        }

        [XmlElement("PubDate")]
        public PubDate pubDate;

        //public Journal()
        //{
        //    _pubDate = new PubDate();
        //}

    }
}
