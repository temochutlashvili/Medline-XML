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
        Panel _panel = new Panel { };
        HighlightedTextBox _firstname = new HighlightedTextBox { Multiline = false };
        HighlightedTextBox _lastname = new HighlightedTextBox { Multiline = false };
        HighlightedTextBox _affiliation = new HighlightedTextBox { Multiline = false };

        Button _up = new Button { };
        Button _down = new Button { };
        Button _delete = new Button { };

        public Author()
        {

        }

        public Author(Article parent, Panel authorsPanel, String lastname, String firstname, String affiliation)
        {
            _parent = parent;

            _authorsPanel = authorsPanel;
            _panel.Height = 20;
            _panel.Width = 1000;
            _authorsPanel.Controls.Add(_panel);
            _firstname.Left = 130;
            _firstname.Width = 40;
            
            _lastname.Left = 20;
            
            _affiliation.Left = 180;
            _affiliation.Width = 500;

            _affiliationInstance = new RawText();
            _affiliation.Text = _affiliationInstance.text = findAffiliation(lastname, affiliation);

            _firstNameInstance = new RawText();
            _firstname.Text = _firstNameInstance.text = removeNumberFromName(firstname);

            _lastNameInstance = new RawText();
            _lastname.Text = _lastNameInstance.text = removeNumberFromName(lastname);

            //_firstname.Text = removeNumberFromName(firstname);
            //_lastname.Text = removeNumberFromName(lastname);

            _up.Left = 700;
            _up.Width = 20;
            _up.Height = 20;
            _up.Image = XMLEditor.Properties.Resources._010_HighPriority_16x16_72;
            _up.BackgroundImageLayout = ImageLayout.Stretch;
            _up.Click += new EventHandler(upButtonClick);
            _down.Left = 730;
            _down.Width = 20;
            _down.Height = 20;
            _down.Image = XMLEditor.Properties.Resources._010_LowPriority_16x16_72;
            _down.BackgroundImageLayout = ImageLayout.Stretch;
            _down.Click += new EventHandler(downButtonClick);
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

        public void addAuthorControls(Article parent, Panel authorsPanel)
        {
            _parent = parent;

            _authorsPanel = authorsPanel;
            _panel.Height = 24;
            _panel.Width = 1000;
            _authorsPanel.Controls.Add(_panel);
            _firstname.Left = 130;
            _firstname.Width = 40;

            _lastname.Left = 20;

            _affiliation.Left = 180;
            _affiliation.Width = 500;
            _affiliation.Text = findAffiliation(this.LastNameTextBox, this._affiliationInstance.text);
            _firstname.Text = removeNumberFromName(this._firstNameInstance.text);
            _lastname.Text = removeNumberFromName(this.LastNameTextBox);

            _up.Left = 700;
            _up.Width = 24;
            _up.Height = 24;
            _up.Image = XMLEditor.Properties.Resources._010_HighPriority_16x16_72;
            _up.BackgroundImageLayout = ImageLayout.Stretch;
            _up.Click += new EventHandler(upButtonClick);
            _down.Left = 730;
            _down.Width = 24;
            _down.Height = 24;
            _down.Image = XMLEditor.Properties.Resources._010_LowPriority_16x16_72;
            _down.BackgroundImageLayout = ImageLayout.Stretch;
            _down.Click += new EventHandler(downButtonClick);
            _delete.Left = 760;
            _delete.Width = 24;
            _delete.Height = 24;
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

        public void reHighlight()
        {
            _firstname.textChanged(this, EventArgs.Empty);
            _lastname.textChanged(this, EventArgs.Empty);
            _affiliation.textChanged(this, EventArgs.Empty);
        }

        public Panel getPanel()
        {
            return _panel;
        }

        [XmlIgnore]
        private RawText _firstNameInstance;

        [XmlElement("FirstName", Order = 1)]
        public RawText firstNameInstance
        {
            get
            {
                _firstNameInstance.text = FirstNameTextBox;
                return _firstNameInstance;
            }

            set
            {
                _firstNameInstance = value;
                FirstNameTextBox = value.text;
            }
        }

        [XmlIgnore]
        public string FirstNameTextBox
        {
            get
            {
                return _firstname.Text;
            }

            set
            {
                _firstname.Text = value;
            }
        }

        [XmlIgnore]
        private RawText _lastNameInstance;

        [XmlElement("LastName", Order = 2)]
        public RawText lastNameInstance
        {
            get
            {
                _lastNameInstance.text = LastNameTextBox;
                return _lastNameInstance;
            }

            set
            {
                _lastNameInstance = value;
                LastNameTextBox = value.text;
            }
        }

        [XmlIgnore]
        public string LastNameTextBox
        {
            get
            {
                return _lastname.Text;
            }

            set
            {
                _lastname.Text = value;
            }
        }

        [XmlIgnore]
        private RawText _affiliationInstance;

        [XmlElement("Affiliation", Order = 3)]
        public RawText affiliationInstance
        {
            get
            {
                _affiliationInstance.text = AffiliationTextBox;
                return _affiliationInstance;
            }

            set
            {
                _affiliationInstance = value;
                AffiliationTextBox = value.text;
            }
        }

        [XmlIgnore]
        public string AffiliationTextBox
        {
            get
            {
                return _affiliation.Text;
            }

            set
            {
                _affiliation.Text = value;
            }
        }

        private String removeNumberFromName(String name)
        {
            return name.Trim().TrimStart("123456789,.;".ToCharArray()).TrimEnd(";,.".ToCharArray());
        }

        private String findAffiliation(String lastname, String affiliation)
        {
            lastname = Regex.Replace(lastname, "&.[^ &;]*;", "");
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
                    if(affies.ContainsKey(numb)) sb.Append(affies[numb]);
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

        public void upButtonClick(object sender, System.EventArgs e)
        {
            _parent.moveAuthorUp(this);
        }

        public void downButtonClick(object sender, System.EventArgs e)
        {
            _parent.moveAuthorDown(this);
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

        //private void rtf_VisibilityChange(object sender, EventArgs e)
        //{
        //    ((RichTextBox)sender).Invalidate();
        //}

    }
}
