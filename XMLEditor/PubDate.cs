using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLEditor
{
    [Serializable]
    public class PubDate
    {
        string _year = DateTime.Now.ToString("yyyy");
        string _month = DateTime.Now.ToString("mm");

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
