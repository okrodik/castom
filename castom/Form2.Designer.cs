namespace castom
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cartochka1 = new castom.Cartochka();
            this.SuspendLayout();
            // 
            // cartochka1
            // 
            this.cartochka1.Checkbox10State = false;
            this.cartochka1.Checkbox1State = false;
            this.cartochka1.Checkbox2State = false;
            this.cartochka1.Checkbox3State = false;
            this.cartochka1.Checkbox4State = false;
            this.cartochka1.Checkbox5State = false;
            this.cartochka1.Checkbox6State = false;
            this.cartochka1.Checkbox7State = false;
            this.cartochka1.Checkbox8State = false;
            this.cartochka1.Checkbox9State = false;
            this.cartochka1.Date = "PAPAPA";
            this.cartochka1.FIO = "PAPAPA";
            this.cartochka1.Location = new System.Drawing.Point(-29, 12);
            this.cartochka1.Name = "cartochka1";
            this.cartochka1.Pol = "PAPAPA";
            this.cartochka1.Quetion1 = "Привет";
            this.cartochka1.Quetion10 = "Привет";
            this.cartochka1.Quetion2 = "Привет";
            this.cartochka1.Quetion3 = "Привет";
            this.cartochka1.Quetion4 = "Привет";
            this.cartochka1.Quetion5 = "Привет";
            this.cartochka1.Quetion6 = "Привет";
            this.cartochka1.Quetion7 = "Привет";
            this.cartochka1.Quetion8 = "Привет";
            this.cartochka1.Quetion9 = "Привет";
            this.cartochka1.Size = new System.Drawing.Size(651, 332);
            this.cartochka1.TabIndex = 0;
            this.cartochka1.Text = "cartochka1";
            this.cartochka1.Work = "PAPAPA";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cartochka1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Cartochka cartochka1;
    }
}