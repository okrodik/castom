using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using castom.Properties;

namespace castom
{
    public class Cartochka : Control
    {
        private PictureBox pictureBox;

        private Panel panel;

        private readonly Label[] labels;
        private readonly Label[] labels2;


        private readonly CheckBox[] checkBoxes;

        private Button button;


        public Cartochka()
        {
            pictureBox = new PictureBox
            {
                Dock = DockStyle.Left,
                Image = Resources.фото,
                BackColor = Color.Red,
                Width = 300,
                Height = 400,
            };

            panel = new Panel
            {
                Location = new Point (310, 0),
                BackColor = Color.LightBlue,
                Padding = new Padding(10),
                Width = 500,
                Height = 150,
                AutoScroll = true
            };

            labels = CreateLabelsArray();
            labels2 = CreateLabels2Array();
            checkBoxes = CreateCheckboxesArray();

            button = new Button
            {
                Text = "Действие",
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Location = new Point(panel.Width - 100, panel.Height - 30),
                Width = 100,
                Height = 30
            };

            button.Click += OnButtonClick;

            // Добавляем элементы в панель
            AddControlsToPanel();

            // Добавляем компоненты на форму
            this.Controls.Add(pictureBox);
            Controls.Add(panel);
        }

        private Label[] CreateLabelsArray()
        {
            return Enumerable.Range(1, 4)
                            .Select(i => new Label
                            {
                                Name = $"label{i}",
                                AutoSize = true,
                            })
                            .ToArray();
        }

        private Label[] CreateLabels2Array()
        {
            return Enumerable.Range(1, 10)
                            .Select(i => new Label
                            {
                                Name = $"label{i}",
                                AutoSize = true,
                            })
                            .ToArray();
        }

        private CheckBox[] CreateCheckboxesArray()
        {
            return Enumerable.Range(1, 10)
                            .Select(i => new CheckBox
                            {
                                Name = $"checkBox{i}",
                                AutoSize = true,
                            })
                            .ToArray();
        }

        private void AddControlsToPanel()
        {
            for (int i = 0; i < 4; i++) 
            {
                labels[i].Text = "PAPAPA";
                labels[i].BackColor = Color.AliceBlue;
                labels[i].Location = new Point(30, 25 + 30 * i);
                panel.Controls.Add(labels[i]);
            }

            int spacingY = 25;      // Расстояние между элементами по Y (вертикальное расстояние)
            int paddingX = 350;     // Отступ от левого края панели
            int yPositionLbl = 170; ; // Стартовая позиция по Y для меток
            int yPositionChk = 170; // Стартовая позиция по Y для чекбоксов

            int chet = 1;
            // Добавление меток слева
            foreach (Label lbl in labels2)
            {
                lbl.Text = "Привет";           // Пример текста
                lbl.BackColor = Color.Lavender;
                lbl.Location = new Point(paddingX, yPositionLbl);
                yPositionLbl += spacingY; // Смещение позиций меток
                this.Controls.Add(lbl);

                if (labels2.Length / 2 == chet) 
                {
                    paddingX = 550;
                    yPositionLbl = 170;
                }
                chet++;
            }

            chet = 1;

            // Добавление чекбоксов справа
            int checkboxHeight = 20;    // Фиксированная высота чекбокса
            int rightPaddingX = 320;    // Правый отступ (для размещения чекбоксов справа)

            foreach (CheckBox chk in checkBoxes)
            {
                chk.Location = new Point(rightPaddingX, yPositionChk); // Слева отступ вправо
                yPositionChk += spacingY ; // Смещение позиций чекбоксов
                this.Controls.Add(chk);

                if (checkBoxes.Length / 2 == chet)
                {
                    rightPaddingX = 520;
                    yPositionChk = 170;
                }
                chet++;
            }

            // Кнопка в самом низу справа
            button.Dock = DockStyle.Bottom;
            this.Controls.Add(button);
        }

        [Category("Custom Properties"), Description("Заголовок первой метки")]
        public string TitleText
        {
            get => labels[0]?.Text;
            set => SetLabelText(0, value);
        }

        [Category("Custom Properties"), Description("Текст второй метки")]
        public string SubTitleText
        {
            get => labels[1]?.Text;
            set => SetLabelText(1, value);
        }

        [Category("Custom Properties"), Description("Текст третьей метки")]
        public string Label3Text
        {
            get => labels[2]?.Text;
            set => SetLabelText(2, value);
        }

        [Category("Custom Properties"), Description("Текст четвертой метки")]
        public string Label4Text
        {
            get => labels[3]?.Text;
            set => SetLabelText(3, value);
        }

        [Category("Custom Properties"), Description("Текст пятой метки")]
        public string Label5Text
        {
            get => labels2[0]?.Text;
            set => SetLabelText(0, value);
        }

        [Category("Custom Properties"), Description("Текст шестой метки")]
        public string Label6Text
        {
            get => labels2[1]?.Text;
            set => SetLabelText2(1, value);
        }

        [Category("Custom Properties"), Description("Текст седьмой метки")]
        public string Label7Text
        {
            get => labels2[2]?.Text;
            set => SetLabelText2(2, value);
        }

        [Category("Custom Properties"), Description("Текст восьмой метки")]
        public string Label8Text
        {
            get => labels2[3]?.Text;
            set => SetLabelText2(3, value);
        }

        [Category("Custom Properties"), Description("Текст девятой метки")]
        public string Label9Text
        {
            get => labels2[4]?.Text;
            set => SetLabelText2(4, value);
        }

        [Category("Custom Properties"), Description("Текст десятой метки")]
        public string Label10Text
        {
            get => labels2[5]?.Text;
            set => SetLabelText2(5, value);
        }

        [Category("Custom Properties"), Description("Текст одиннадцатой метки")]
        public string Label11Text
        {
            get => labels2[6]?.Text;
            set => SetLabelText2(6, value);
        }

        [Category("Custom Properties"), Description("Текст двенадцатой метки")]
        public string Label12Text
        {
            get => labels2[7]?.Text;
            set => SetLabelText2(7, value);
        }

        [Category("Custom Properties"), Description("Текст тринадцатой метки")]
        public string Label13Text
        {
            get => labels2[8]?.Text;
            set => SetLabelText2(8, value);
        }

        [Category("Custom Properties"), Description("Текст четырнадцатой метки")]
        public string Label14Text
        {
            get => labels2[9]?.Text;
            set => SetLabelText2(9, value);
        }

        // Чекбоксы
        [Category("Custom Properties"), Description("Первый чекбокс")]
        public bool Checkbox1State
        {
            get => checkBoxes[0]?.Checked ?? false;
            set => SetCheckboxState(0, value);
        }

        [Category("Custom Properties"), Description("Второй чекбокс")]
        public bool Checkbox2State
        {
            get => checkBoxes[1]?.Checked ?? false;
            set => SetCheckboxState(1, value);
        }

        [Category("Custom Properties"), Description("Третий чекбокс")]
        public bool Checkbox3State
        {
            get => checkBoxes[2]?.Checked ?? false;
            set => SetCheckboxState(2, value);
        }

        [Category("Custom Properties"), Description("Четвертый чекбокс")]
        public bool Checkbox4State
        {
            get => checkBoxes[3]?.Checked ?? false;
            set => SetCheckboxState(3, value);
        }

        [Category("Custom Properties"), Description("Пятый чекбокс")]
        public bool Checkbox5State
        {
            get => checkBoxes[4]?.Checked ?? false;
            set => SetCheckboxState(4, value);
        }

        [Category("Custom Properties"), Description("Шестой чекбокс")]
        public bool Checkbox6State
        {
            get => checkBoxes[5]?.Checked ?? false;
            set => SetCheckboxState(5, value);
        }

        [Category("Custom Properties"), Description("Седьмой чекбокс")]
        public bool Checkbox7State
        {
            get => checkBoxes[6]?.Checked ?? false;
            set => SetCheckboxState(6, value);
        }

        [Category("Custom Properties"), Description("Восьмой чекбокс")]
        public bool Checkbox8State
        {
            get => checkBoxes[7]?.Checked ?? false;
            set => SetCheckboxState(7, value);
        }

        [Category("Custom Properties"), Description("Девятый чекбокс")]
        public bool Checkbox9State
        {
            get => checkBoxes[8]?.Checked ?? false;
            set => SetCheckboxState(8, value);
        }

        [Category("Custom Properties"), Description("Десятый чекбокс")]
        public bool Checkbox10State
        {
            get => checkBoxes[9]?.Checked ?? false;
            set => SetCheckboxState(9, value);
        }

        [Category("Внешний вид"), Description("Цвет фона карточки")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                panel.BackColor = value;
            }
        }

        [Category("Внешний вид"), Description("Размер шрифта всех надписей")]
        public float LabelsFontSize
        {
            get => labels.FirstOrDefault()?.Font.Size ?? 10f;
            set
            {
                foreach (var label in labels)
                {
                    label.Font = new Font(label.Font.FontFamily, value);
                }
            }
        }

        protected virtual void SetLabelText(int index, string text)
        {
            if (labels[index] != null)
                labels[index].Text = text;
        }
        protected virtual void SetLabelText2(int index, string text)
        {
            if (labels2[index] != null)
                labels2[index].Text = text;
        }

        protected virtual void SetCheckboxState(int index, bool state)
        {
            if (checkBoxes[index] != null)
                checkBoxes[index].Checked = state;
        }

        protected virtual void OnButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нажали кнопку!", "Карточка");
        }
    }
}
