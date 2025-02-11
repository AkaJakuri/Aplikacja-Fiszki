namespace fiszki_aplikacja_okienkowa
{
    partial class FormDodajFiszke
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
            button1 = new Button();
            comboBoxKategoria = new ComboBox();
            comboBoxPoziom = new ComboBox();
            textBoxSlowo = new TextBox();
            textBoxTlumaczenie = new TextBox();
            textBoxZdanie = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(325, 318);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 0;
            button1.Text = "dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxKategoria
            // 
            comboBoxKategoria.FormattingEnabled = true;
            comboBoxKategoria.Location = new Point(325, 104);
            comboBoxKategoria.Name = "comboBoxKategoria";
            comboBoxKategoria.Size = new Size(151, 28);
            comboBoxKategoria.TabIndex = 1;
            // 
            // comboBoxPoziom
            // 
            comboBoxPoziom.FormattingEnabled = true;
            comboBoxPoziom.Location = new Point(325, 157);
            comboBoxPoziom.Name = "comboBoxPoziom";
            comboBoxPoziom.Size = new Size(151, 28);
            comboBoxPoziom.TabIndex = 2;
            // 
            // textBoxSlowo
            // 
            textBoxSlowo.Location = new Point(96, 251);
            textBoxSlowo.Name = "textBoxSlowo";
            textBoxSlowo.Size = new Size(151, 27);
            textBoxSlowo.TabIndex = 3;
            // 
            // textBoxTlumaczenie
            // 
            textBoxTlumaczenie.Location = new Point(325, 251);
            textBoxTlumaczenie.Name = "textBoxTlumaczenie";
            textBoxTlumaczenie.Size = new Size(151, 27);
            textBoxTlumaczenie.TabIndex = 4;
            // 
            // textBoxZdanie
            // 
            textBoxZdanie.Location = new Point(583, 251);
            textBoxZdanie.Name = "textBoxZdanie";
            textBoxZdanie.Size = new Size(125, 27);
            textBoxZdanie.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(216, 9);
            label1.Name = "label1";
            label1.Size = new Size(365, 46);
            label1.TabIndex = 6;
            label1.Text = "dodawanie nowej fiszki";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 81);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "kategoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 134);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 8;
            label3.Text = "poziom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 219);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 9;
            label4.Text = "słowo po angielsku";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(325, 219);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 10;
            label5.Text = "tłumaczenie";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(583, 219);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 11;
            label6.Text = "przykład zdania";
            // 
            // FormDodajFiszke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxZdanie);
            Controls.Add(textBoxTlumaczenie);
            Controls.Add(textBoxSlowo);
            Controls.Add(comboBoxPoziom);
            Controls.Add(comboBoxKategoria);
            Controls.Add(button1);
            Name = "FormDodajFiszke";
            Text = "FormDodajFiszke";
            Load += FormDodajFiszke_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBoxKategoria;
        private ComboBox comboBoxPoziom;
        private TextBox textBoxSlowo;
        private TextBox textBoxTlumaczenie;
        private TextBox textBoxZdanie;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}