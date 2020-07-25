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

        private void upClick(object sender, EventArgs e)
        {
            
        }
    }

}
