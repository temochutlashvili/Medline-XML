using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLEditor
{
    public partial class PreviewForm : Form
    {
        public PreviewForm(Article article)
        {
            InitializeComponent();
            titleTextBox.Text = Unescape(article.ArticleTitleTextBox);
            abstractTextBox.Text = Unescape(article.AbstractTextBox);
            foreach(Author author in article._authors)
            {
                addAuthor(author);
            }
        }

        public string Unescape(string escaped)
        {
            Regex r = new Regex("&(.[^ &;]*);");
            MatchCollection m = r.Matches(escaped);
            while (m.Count > 0)
            {
                var i = Int64.Parse(m[0].Groups[1].Value);

                escaped = escaped.Remove(m[0].Index, m[0].Length);
                escaped = escaped.Insert(m[0].Index, ((char)i).ToString());

                m = r.Matches(escaped);
            }

            return escaped;
        }

        private void addAuthor(Author author)
        {
            Panel _panel = new Panel { };
            RichTextBox _firstname = new RichTextBox { Multiline = false, ReadOnly = true };
            RichTextBox _lastname = new RichTextBox { Multiline = false, ReadOnly = true };
            RichTextBox _affiliation = new RichTextBox { Multiline = false, ReadOnly = true };

            _panel.Height = 20;
            _panel.Width = 1000;
            authorsPanel.Controls.Add(_panel);
            _firstname.Left = 130;
            _firstname.Width = 40;

            _lastname.Left = 20;

            _affiliation.Left = 180;
            _affiliation.Width = 500;

            _firstname.Text = Unescape(author.FirstNameTextBox);
            _lastname.Text = Unescape(author.LastNameTextBox);
            _affiliation.Text = Unescape(author.AffiliationTextBox);

            _panel.Controls.Add(_firstname);
            _panel.Controls.Add(_lastname);
            _panel.Controls.Add(_affiliation);
        }

    }
}
