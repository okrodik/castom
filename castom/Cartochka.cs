using castom.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace castom
{
    public class Cartochka : Control
    {
        private PictureBox pictureBox;

        private Panel panel;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;

        private Button button;


        public Cartochka()
        {
            pictureBox = new PictureBox();

            pictureBox.Location = new Point(10, 10);
            pictureBox.Width = this.Width;
            pictureBox.Height = this.Height;

            pictureBox.Size = new Size(this.Width, this.Height);
            pictureBox.Image = Resources.фото;
            pictureBox.BackColor = Color.Red;

            this.Controls.Add(pictureBox);
        }


        //private void OnTextChanged(object sender, EventArgs e)
        //{
        //    this.Invalidate();
        //}

        //private void pictureBox_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("ok");
        //}

        //private void CustomTextBox_Resize(object sender, EventArgs e)
        //{
        //    pictureBox.Size = new Size(iconWidth, this.Height);
        //    textBox.Location = new Point(iconWidth + 5, 0);
        //    textBox.Width = this.Width - (iconWidth + 5);
        //    textBox.Height = this.Height;
        //}

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //}

        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);
        //    textBox.Height = this.Height;
        //}
    }
}
