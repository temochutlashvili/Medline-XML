using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace XMLEditor
{
    public partial class HighlightedTextBox : RichTextBox
    {
        private Color highlightColor = Color.Yellow;

        public HighlightedTextBox()
        {
            InitializeComponent();
        }

        public void highlightedTextBox_VisibilityChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        public void textChanged(object sender, EventArgs e)
        {
            findAndHighlight();
        }

        private void findAndHighlight()
        {
            // Backup the users current selection point.  
            int selectionStart = SelectionStart;
            int selectionLength = SelectionLength;

            ParseLine(Text);

            //foreach (string l in Lines)
            //{
            //    ParseLine(l);
            //}

            // Restore the users current selection point.   
            SelectionStart = selectionStart;
            SelectionLength = selectionLength;
        }

        private void ParseLine(string line)
        {
            Regex r = new Regex("&.[^ &;]*;");
            foreach (Match m in r.Matches(line))
            {
                //Console.WriteLine(m.Groups[1].Value);
                this.SelectionStart = m.Index;
                this.SelectionLength = m.Length;
                this.SelectionBackColor = highlightColor;
            }
        }

    }
}
