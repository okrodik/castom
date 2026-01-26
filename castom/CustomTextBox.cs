using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace castom
{
    public class CustomTextBox : UserControl
    {
        private TextBox textBox;
        private PictureBox pictureBox;
        private int iconWidth = 30;

        public Image Icon
        {
            get { return pictureBox.Image; }
            set
            {
                pictureBox.Image = value;
                this.Invalidate();
            }
        }

       public CustomTextBox()
        {
            textBox = new TextBox();
            pictureBox = new PictureBox();

            this.Controls.Add(textBox);
            this.Controls.Add(pictureBox);

            textBox.Location = new Point(iconWidth + 10, 0);
            textBox.Width = this.Width - (iconWidth + 10);
            textBox.Height = this.Height;

            pictureBox.Size = new Size (iconWidth, this.Height);
            pictureBox.SizeMode =  PictureBoxSizeMode.StretchImage;

            this.Resize += CustomTextBox_Resize;
            textBox.TextChanged += OnTextChanged;
            pictureBox.Click += new EventHandler(pictureBox_Click);
        }



        private void OnTextChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok");
        }

        private void CustomTextBox_Resize(object sender, EventArgs e)
        {
            pictureBox.Size = new Size(iconWidth, this.Height);
            textBox.Location = new Point(iconWidth + 5, 0);
            textBox.Width = this.Width - (iconWidth + 5);
            textBox.Height = this.Height;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            textBox.Height = this.Height;
        }
    }
}
