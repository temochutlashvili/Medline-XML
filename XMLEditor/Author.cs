using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XMLEditor
{
    [Serializable]
    public class Author : IDisposable
    {
        Article _parent;

        Panel _authorsPanel;
        Panel _panel;
        TextBox _firstname;
        TextBox _lastname;
        TextBox _affiliation;

        Button _up;
        Button _down;
        Button _delete;

        public Author()
        {

        }

        public Author(Article parent, Panel authorsPanel, String lastname, String firstname, String affiliation)
        {
            _parent = parent;

            _authorsPanel = authorsPanel;
            _panel = new Panel { };
            _panel.Height = 20;
            _panel.Width = 1000;
            _authorsPanel.Controls.Add(_panel);
            _firstname = new TextBox { };
            _firstname.Left = 130;
            _firstname.Width = 40;
            
            _lastname = new TextBox { };
            _lastname.Left = 20;
            
            _affiliation = new TextBox { };
            _affiliation.Left = 180;
            _affiliation.Width = 500;
            _affiliation.Text = findAffiliation(lastname, affiliation);

            _firstname.Text = removeNumberFromName(firstname);
            _lastname.Text = removeNumberFromName(lastname);

            _up = new Button { };
            _up.Left = 700;
            _up.Width = 20;
            _up.Height = 20;
            _down = new Button { };
            _down.Left = 730;
            _down.Width = 20;
            _down.Height = 20;
            _down.Image = XMLEditor.Properties.Resources._010_LowPriority_16x16_72;
            _down.BackgroundImageLayout = ImageLayout.Stretch;
            _delete = new Button { };
            _delete.Left = 760;
            _delete.Width = 20;
            _delete.Height = 20;
            _delete.Image = XMLEditor.Properties.Resources._1385_Disable_16x16_72;
            _delete.BackgroundImageLayout = ImageLayout.Stretch;
            _delete.Click += new EventHandler(deleteButtonClick);


            _panel.Controls.Add(_firstname);
            _panel.Controls.Add(_lastname);
            _panel.Controls.Add(_affiliation);

            _panel.Controls.Add(_up);
            _panel.Controls.Add(_down);
            _panel.Controls.Add(_delete);
        }

        [XmlElement]
        public string Firstname
        {
            get{ return _firstname.Text; }

            set{ _firstname.Text = value; }
        }

        [XmlElement]
        public string Lastname
        {
            get{ return _lastname.Text; }

            set{ _lastname.Text = value; }
        }

        [XmlElement]
        public string Affiliation
        {
            get{ return _affiliation.Text; }

            set{ _affiliation.Text = value; }
        }

        private String removeNumberFromName(String name)
        {
            return name.Trim().TrimStart("123456789,.;".ToCharArray()).TrimEnd(";,.".ToCharArray());
        }

        private String findAffiliation(String lastname, String affiliation)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, string> affies = parseAffiliation(affiliation);
            var affiliationReg = new Regex(@"([^a-zA-Z]+)(.*)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            var matchAuthorCollection = affiliationReg.Matches(lastname);
            
            if(matchAuthorCollection.Count > 0)
            {
                var numbers = matchAuthorCollection[0].Groups[1].Value;
                var name = matchAuthorCollection[0].Groups[2].Value;

                foreach(String numb in numbers.Split(','))
                {
                    sb.Append(affies[numb]);
                }
            } else
            {
                sb.Append(affiliation);
            }
            
            return sb.ToString();
        }

        private Dictionary<string, string> parseAffiliation(String affiliation)
        {
            var result = new Dictionary<string, string>();
            var startIndex = 0;
            var i = 0;
            String slice = "";

            while(i < affiliation.Length )
            {
                if (affiliation[i] == (startIndex + 1).ToString()[0])
                {
                    if (slice.Length > 0) result.Add((startIndex).ToString(), removeNumberFromName(slice));
                    slice = "";
                    startIndex++;
                }
                slice += affiliation[i++];
            }

            if (slice.Length > 0) result.Add((startIndex).ToString(), removeNumberFromName(slice));

            return result;
        }

        public void deleteButtonClick(object sender, System.EventArgs e)
        {
            _parent.deleteAuthor(this);
        }

        public void Dispose()
        {
            _up.Dispose();
            _down.Dispose();
            _delete.Dispose();
            _firstname.Dispose();
            _lastname.Dispose();
            _affiliation.Dispose();
            _panel.Dispose();

        }

    }
}
