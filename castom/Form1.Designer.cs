namespace castom
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.customTextBox1 = new castom.CustomTextBox();
            this.customButton1 = new castom.CustomButton();
            this.SuspendLayout();
            // 
            // customTextBox1
            // 
            this.customTextBox1.Icon = null;
            this.customTextBox1.Location = new System.Drawing.Point(422, 69);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Size = new System.Drawing.Size(140, 146);
            this.customTextBox1.TabIndex = 1;
            // 
            // customButton1
            // 
            this.customButton1.BTNColor = System.Drawing.Color.LightBlue;
            this.customButton1.Location = new System.Drawing.Point(143, 40);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(171, 159);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "customButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.customButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton customButton1;
        private CustomTextBox customTextBox1;
    }
}

