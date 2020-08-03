using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLEditor
{
    [Serializable]
    public sealed class PubDate
    {
        private static readonly PubDate instance = new PubDate();

        static string _year;
        static string _month;

        static PubDate()
        {
        }

        private PubDate()
        {

        }

        public static PubDate Instance
        {
            get
            {
                return instance;
            }
        }

        [XmlElement]
        public string Year
        {
            get
            {
                return _year;
            }

            set
            {
                _year = value;
            }
        }

        [XmlElement]
        public string Month
        {
            get
            {
                return _month;
            }

            set
            {
                _month = value;
            }
        }
    }
}
