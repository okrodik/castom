using System;
using System.Drawing;
using System.Windows.Forms;

namespace castom
{
    public class Calculator : Control
    {
        private TextBox displayTextBox;
        private Button[] numberButtons;
        private Button buttonPlus, buttonMinus, buttonUmn, buttonDel, buttonRavno, buttonC;
        private double currentResult;
        private string currentOperation;
        private bool operationPerformed;

        public Calculator()
        {
            displayTextBox = new TextBox();
            displayTextBox.Dock = DockStyle.Top;
            displayTextBox.TextAlign = HorizontalAlignment.Right;

            numberButtons = new Button[10];

            for (int i = 0; i < 10; i++)
            {
                numberButtons[i] = new Button();
                numberButtons[i].Text = i.ToString();
                numberButtons[i].Size = new Size(80, 80);
                numberButtons[i].Tag = i;

                numberButtons[i].Click += NumberButton_Click;
            }

            buttonPlus = CreateOperatorButton("+");
            buttonMinus = CreateOperatorButton("-");
            buttonUmn = CreateOperatorButton("*");
            buttonDel = CreateOperatorButton("/");
            buttonRavno = CreateOperatorButton("=");
            buttonC = CreateOperatorButton("C");

            TableLayoutPanel mainLayout = new TableLayoutPanel();
            mainLayout.RowCount = 5;
            mainLayout.ColumnCount = 4;
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.AutoSize = true;
            mainLayout.BackColor = Color.AliceBlue;

            for (int i = 2; i >= 0; i--) 
            {
                for (int j = 0; j < 3; j++) 
                {
                    int buttonIndex = (i * 3) + j + 1;
                    if (buttonIndex < 10) 
                    {
                        mainLayout.Controls.Add(numberButtons[buttonIndex], j, 2 - i); 
                    }
                }
            }

            mainLayout.Controls.Add(numberButtons[0], 1, 3);
            mainLayout.Controls.Add(buttonPlus, 3, 0);
            mainLayout.Controls.Add(buttonMinus, 3, 1);
            mainLayout.Controls.Add(buttonUmn, 3, 2);
            mainLayout.Controls.Add(buttonDel, 3, 3);
            mainLayout.Controls.Add(buttonRavno, 2, 3);
            mainLayout.Controls.Add(buttonC, 0, 3);

            this.Controls.Add(mainLayout);
            this.Controls.Add(displayTextBox);
            this.Size = new Size(400, 600);

        }

        private Button CreateOperatorButton(string text)
        {
            Button button = new Button();
            button.Text = text;
            button.Size = new Size(80, 80);

            button.Click += OperatorButton_Click;
            return button;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (operationPerformed)
                {
                    displayTextBox.Clear();
                    operationPerformed = false;
                }
                displayTextBox.Text += button.Text;
            }
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button.Text == "C")
                {
                    displayTextBox.Clear();
                    currentResult = 0;
                    currentOperation = "";
                }
                else if (button.Text == "=")
                {
                    Rachet();
                    currentOperation = "";
                }
                else
                {
                    Rachet();
                    currentOperation = button.Text;
                    currentResult = double.Parse(displayTextBox.Text);
                    operationPerformed = true;
                }
            }
        }

        private void Rachet()
        {
            if (currentOperation == string.Empty || operationPerformed)
            {
                return;
            }

            double chilso = double.Parse(displayTextBox.Text);

            switch (currentOperation)
            {
                case "+":
                    currentResult += chilso;
                    break;
                case "-":
                    currentResult -= chilso;
                    break;
                case "*":
                    currentResult *= chilso;
                    break;
                case "/":
                    if (chilso != 0)
                        currentResult /= chilso;
                    else
                        MessageBox.Show("Нельзя делить на ноль!");
                    break;
            }
            displayTextBox.Text = currentResult.ToString();
        }
    }
}
