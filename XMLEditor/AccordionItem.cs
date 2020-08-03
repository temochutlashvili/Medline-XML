using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLEditor
{
    public partial class AccordionItem : Form
    {

        public AccordionItem()
        {
            InitializeComponent();
        }

        public Panel getControl()
        {
            return this.panel1;
        }

        public Panel getAuthorsControl()
        {
            return this.authorsPanel;
        }

        public TextBox getFirstPage()
        {
            return pageStartTextBox;
        }

        public TextBox getLastPage()
        {
            return pageEndTextBox;
        }

        public ComboBox getLanguage()
        {
            return languageComboBox;
        }

        public RichTextBox getAbstract()
        {
            return abstractTextBox;
        }

        public RichTextBox getTitle()
        {
            return titleTextBox;
        }

        private void rtf_VisibilityChange(object sender, EventArgs e)
        {
            ((RichTextBox)sender).Invalidate();
        }
    }

}
