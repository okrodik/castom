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


            Cartochka cartochka = new Cartochka
            {
            };

            this.Controls.Add(cartochka);
        }

        private void settingWindows()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
