using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLEditor
{
    [Serializable]
    public class Journal
    {
        string _publisherName = "";
        string _journalTitle = "Geogian Medical News";
        string _iSSN = "";
        string _volume = "";
        string _issue = "";
        PubDate _pubDate;

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

        [XmlElement]
        public PubDate PubDate
        {
            get
            {
                return _pubDate;
            }

            set
            {
                _pubDate = value;
            }
        }

        public Journal()
        {
            _pubDate = new PubDate();
        }



    }
}
