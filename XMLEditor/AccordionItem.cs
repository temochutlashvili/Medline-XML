using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLEditor
{
    class AccordionItem
    {
        public Panel panel;
        private TextBox title; 

        public AccordionItem()
        {
            panel = new Panel { Dock = DockStyle.Fill };

        }
    }
}
