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

namespace XMLEditor
{
    public partial class HighlightedTextBox : TextBox
    {
        public HighlightedTextBox()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Brush b = new SolidBrush(this.ForeColor);
            Rectangle old = this.ClientRectangle;
            Font f = new Font(this.Font, FontStyle.Bold);
            g.DrawString(this.Text, this.Font, b, old);
            //Rectangle old = this.ClientRectangle;
            //Rectangle R = new Rectangle(Multiline ? old.X + 1 : old.X - 2, old.Y + 1, old.Width, old.Height);
            //TextRenderer.DrawText(e.Graphics, this.Text, this.Font, R, Color.Red, Color.White, TextFormatFlags.Internal);
        }
    }
}
