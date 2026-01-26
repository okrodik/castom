using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace castom
{
    public class CustomButton : Control
    {
        private Color btnColor = Color.LightBlue;
        public string Name;

        public Color BTNColor
        {
            get { return btnColor; }
            set
            {
                btnColor = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using(SolidBrush brush = new SolidBrush(btnColor))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            using (SolidBrush textBrush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString(Text, this.Font, textBrush, 10, 10);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            MessageBox.Show("Кнопка нажата");
        }
    }
}
