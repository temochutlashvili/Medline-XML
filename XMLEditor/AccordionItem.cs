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

        public HighlightedTextBox getAbstract()
        {
            return abstractTextBox;
        }

        public HighlightedTextBox getTitle()
        {
            return titleTextBox;
        }

        public Button getPreviewButton()
        {
            return previewButton;
        }

        public Button getDeleteButton()
        {
            return deleteButton;
        }

        public Button getUpButton()
        {
            return upButton;
        }

        public Button getDownButton()
        {
            return downButton;
        }

        private void rtf_VisibilityChange(object sender, EventArgs e)
        {
            ((RichTextBox)sender).Invalidate();
        }
    }

}
