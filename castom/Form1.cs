using System;
using System.Drawing;
using System.Windows.Forms;

namespace castom
{
    public partial class Form1 : Form
    {
        private Cartochka cartochka;
        private Calculator calculator;

        public Form1()
        {
            InitializeComponent();

            cartochka = new Cartochka();

            cartochka.Location = new Point(10, 10);
            cartochka.Size = new Size(850, 500);

            Controls.Add(cartochka);

            // Основная информация
            cartochka.FIO = "Оконешников Родион";
            cartochka.Date = "08.01.2006";
            cartochka.Pol = "Мужской";
            cartochka.Work = "Программист";

            // Все вопросы
            cartochka.Quetion1 = "1. Любите ли вы программировать?";
            cartochka.Quetion2 = "2. Работаете ли вы в команде?";
            cartochka.Quetion3 = "3. Знаете ли вы C#?";
            cartochka.Quetion4 = "4. Используете ли Git?";
            cartochka.Quetion5 = "5. Работаете ли с базами данных?";
            cartochka.Quetion6 = "6. Знаете ли JavaScript?";
            cartochka.Quetion7 = "7. Используете ли Visual Studio?";
            cartochka.Quetion8 = "8. Работаете ли с API?";
            cartochka.Quetion9 = "9. Знаете ли SQL?";
            cartochka.Quetion10 = "10. Любите ли отладку кода?";

            calculator = new Calculator();

            calculator.Location = new Point(900, 10);
            calculator.Size = new Size(400, 400);


            Controls.Add(calculator);
        }
    }
}
