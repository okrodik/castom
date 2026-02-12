using System;
using System.Drawing;
using System.Windows.Forms;

public partial class Calculator : Control
{
    #region Поля

    private Label displayLabel;                   // Показатель
    private Button[] numericButtons;              // Кнопки с цифрами
    private Button[] operationButtons;            // Кнопки операций
    private Button decimalPointButton;            // Кнопка запятой
    private Button equalButton;                   // Кнопка равенства
    private Button resetButton;                   // Кнопка сброса
    private Button signChangeButton;              // Кнопка смены знака

    #endregion

    #region Переменные состояния

    private string currentDisplayValue = "0";     // Текущее значение на дисплее
    private double firstOperand = 0;              // Первый операнд
    private char pendingOperation = ' ';          // Сохранённая операция
    private bool awaitingNewInput = true;         // Признак начала нового ввода

    #endregion

    #region Конструктор и инициализация

    public Calculator()
    {
        // Дисплей калькулятора
        displayLabel = new Label
        {
            Dock = DockStyle.Top,
            Text = "0",
            Font = new Font("Arial", 24, FontStyle.Bold),
            TextAlign = ContentAlignment.MiddleRight,
            BackColor = Color.White,
            Height = 50
        };

        // Таблица для размещения кнопок
        TableLayoutPanel buttonPanel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 4,
            RowCount = 5,
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        };

        // Цифровые кнопки
        numericButtons = new Button[10];
        for (int i = 0; i < numericButtons.Length; i++)
        {
            numericButtons[i] = new Button
            {
                Text = i.ToString(),
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 16, FontStyle.Bold)
            };
            numericButtons[i].Click += NumericButton_Click;
        }

        // Кнопки операций
        operationButtons = new Button[4]
        {
            new Button { Text = "+", Dock = DockStyle.Fill },
            new Button { Text = "-", Dock = DockStyle.Fill },
            new Button { Text = "*", Dock = DockStyle.Fill },
            new Button { Text = "/", Dock = DockStyle.Fill }
        };
        foreach (var button in operationButtons)
        {
            button.Click += OperationButton_Click;
        }

        // Остальные специальные кнопки
        decimalPointButton = new Button
        {
            Text = ".",
            Dock = DockStyle.Fill
        };
        decimalPointButton.Click += DecimalPointButton_Click;

        equalButton = new Button
        {
            Text = "=",
            Dock = DockStyle.Fill
        };
        equalButton.Click += EqualButton_Click;

        resetButton = new Button
        {
            Text = "C",
            Dock = DockStyle.Fill
        };
        resetButton.Click += ResetButton_Click;

        signChangeButton = new Button
        {
            Text = "+/-",
            Dock = DockStyle.Fill
        };
        signChangeButton.Click += SignChangeButton_Click;

        // Добавляем кнопки в таблицу
        buttonPanel.Controls.Add(resetButton, 0, 0);
        buttonPanel.Controls.Add(signChangeButton, 1, 0);
        buttonPanel.Controls.Add(decimalPointButton, 2, 0);
        buttonPanel.Controls.Add(equalButton, 3, 0);

        buttonPanel.Controls.Add(numericButtons[7], 0, 1);
        buttonPanel.Controls.Add(numericButtons[8], 1, 1);
        buttonPanel.Controls.Add(numericButtons[9], 2, 1);
        buttonPanel.Controls.Add(operationButtons[0], 3, 1); // +

        buttonPanel.Controls.Add(numericButtons[4], 0, 2);
        buttonPanel.Controls.Add(numericButtons[5], 1, 2);
        buttonPanel.Controls.Add(numericButtons[6], 2, 2);
        buttonPanel.Controls.Add(operationButtons[1], 3, 2); // -

        buttonPanel.Controls.Add(numericButtons[1], 0, 3);
        buttonPanel.Controls.Add(numericButtons[2], 1, 3);
        buttonPanel.Controls.Add(numericButtons[3], 2, 3);
        buttonPanel.Controls.Add(operationButtons[2], 3, 3); // *

        buttonPanel.Controls.Add(numericButtons[0], 0, 4);
        buttonPanel.SetColumnSpan(equalButton, 4); // делаем кнопку '=' растянутой на 4 колонки
        buttonPanel.Controls.Add(equalButton, 0, 4); // кнопка '='

        // Собираем все части
        this.Controls.Add(displayLabel);
        this.Controls.Add(buttonPanel);
    }

    #endregion

    #region Обработчики событий

    private void NumericButton_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        string digit = btn.Text;

        if (awaitingNewInput)
        {
            currentDisplayValue = digit;
            awaitingNewInput = false;
        }
        else
        {
            currentDisplayValue += digit;
        }

        DisplayUpdate();
    }

    private void DecimalPointButton_Click(object sender, EventArgs e)
    {
        if (!currentDisplayValue.Contains("."))
        {
            currentDisplayValue += ".";
            DisplayUpdate();
        }
    }

    private void OperationButton_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        string operationSymbol = btn.Text;

        if (double.TryParse(currentDisplayValue, out double tempNum))
        {
            firstOperand = tempNum;
            pendingOperation = operationSymbol[0];
            awaitingNewInput = true;
        }
    }

    private void EqualButton_Click(object sender, EventArgs e)
    {
        if (pendingOperation != ' ')
        {
            double secondOperand = double.Parse(currentDisplayValue);
            double result = 0;

            switch (pendingOperation)
            {
                case '+': result = firstOperand + secondOperand; break;
                case '-': result = firstOperand - secondOperand; break;
                case '*': result = firstOperand * secondOperand; break;
                case '/': result = firstOperand / secondOperand; break;
            }

            currentDisplayValue = result.ToString();
            awaitingNewInput = true;
            pendingOperation = ' ';
            DisplayUpdate();
        }
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        currentDisplayValue = "0";
        firstOperand = 0;
        pendingOperation = ' ';
        awaitingNewInput = true;
        DisplayUpdate();
    }

    private void SignChangeButton_Click(object sender, EventArgs e)
    {
        if (double.TryParse(currentDisplayValue, out double tempNum))
        {
            currentDisplayValue = (-tempNum).ToString();
            DisplayUpdate();
        }
    }

    #endregion

    #region Вспомогательные методы

    private void DisplayUpdate()
    {
        displayLabel.Text = currentDisplayValue;
    }

    #endregion
}