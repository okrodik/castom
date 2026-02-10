using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using castom.Properties;

namespace castom
{
    public partial class Calculator : UserControl
    {
        private TextBox pictureBox;

        private readonly Button[] buttons;

        public Calculator()
        {
            buttons = CreateButtonArray();
            AddControlsToPanel();
        }

        private Button[] CreateButtonArray()
        {
            Button[] buttons = new Button[4];
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button
                {
                    Name = $"button{i + 1}",
                    AutoSize = true
                };
            }
            return buttons;
        }


        private void AddControlsToPanel()
        {
            int xxx = 10;
            foreach (Button btn in buttons)
            {
                btn.Location = new Point(10 + xxx, 10 + xxx);
                this.Controls.Add(btn);
            }
        }

        [Category("Внешний вид"), Description("Цвет фона карточки")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                this.BackColor = value;
            }
        }

        protected virtual void OnButtonClick(object sender, EventArgs e)
        {
        }
    }
}
