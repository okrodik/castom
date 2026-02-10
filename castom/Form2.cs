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
        Cartochka customElement = new Cartochka();
        public Form2()
        {
            InitializeComponent();

            customElement.Location = new Point(10, 10); // Установка позиции
            customElement.Dock = DockStyle.Fill;
            this.Controls.Add(customElement);            
            
            settingWindows();
        }

        private void settingWindows()
        {
            customElement.Quetion1 = "Вы учитесь?";
            customElement.Quetion2 = "Вы работаете?";
            customElement.Quetion3 = "Вы учитесь?";
            customElement.Quetion4 = "Вы учитесь";
            customElement.Quetion5 = "Вы учитесь";
            customElement.Quetion6 = "Вы учитесь";
            customElement.Quetion7 = "Вы учитесь";
            customElement.Quetion8 = "Вы учитесь";
            customElement.Quetion9 = "Вы учитесь";
            customElement.Quetion10 = "Вы учитесь";

            customElement.FIO = "Зубенко Михаил Петрович";
            customElement.Date = "08.01.2006";
            customElement.Pol = "Мужской";
            customElement.Work = "Студент";

            customElement.BackColor = Color.GreenYellow;
        }
    }
}
