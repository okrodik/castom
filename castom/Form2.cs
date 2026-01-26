using castom.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace castom
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            settingWindows();
            Button btn1 = new Button
            {
                Text = "Кнопка 1",
                BackColor = Color.White,
                Size = new Size(100, 100),
                Location = new Point(15, 15)
            };

            CustomButton btn2 = new CustomButton
            {
                Text = "Кнопка",
                BackColor = Color.Red,
                Size = new Size(100, 100),
                Location = new Point(115, 15)
            };

            CustomTextBox txt1 = new CustomTextBox
            {
                Icon = Image.FromFile("C:\\Users\\student1\\Downloads\\фото.jpg"),
                Size = new Size(100, 100),
                Location = new Point(15, 15),
                Font = new Font("Arial", 15),
                Name = ""
            };

            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            this.Controls.Add(txt1);
        }

        private void settingWindows()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
