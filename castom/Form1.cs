using castom.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace castom
{
    public partial class Form1 : Form
    {
        PictureBox pictureBox = new PictureBox();
        Panel panel = new Panel();

        public Form1()
        {
            InitializeComponent();
            createPole();
        }

        private void createPole()
        {
            pictureBox.Size = new Size(300, 400);
            pictureBox.BackColor = Color.LightCoral;
            pictureBox.Location = new Point(10, 10);
            pictureBox.Image = Resources.фото;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox);

            panel.Size = new Size(300, 200);
            panel.BackColor = Color.LightBlue;
            panel.Location = new Point(320, 10);
            this.Controls.Add((panel));

            for (int i = 0; i < 4; i++)
            {
                Label label = new Label();
                label.Text = i.ToString();
                label.Location = new Point(10, 10 + 50 * i);
                label.BackColor = Color.Yellow;
                label.Name = i.ToString();
                label.Size = new Size(280, 30);
                label.Tag = i.ToString();
                panel.Controls.Add(label);
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    CheckBox checkBox = new CheckBox();
                    Label label2 = new Label();

                    checkBox.Location = new Point(320 + 80 * i, 210 + 20 * j);
                    label2.Location = new Point(320 + 80 * i, 210 + 20 * j);

                    label2.BackColor = Color.Yellow;

                    this.Controls.Add(checkBox);
                    this.Controls.Add(label2);
                }
            }
        }
    }
}
