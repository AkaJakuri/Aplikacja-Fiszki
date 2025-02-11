namespace fiszki_aplikacja_okienkowa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            los_slowa = new Button();
            wylosowane_slowo = new Label();
            tlumaczenie = new TextBox();
            sprawdzanie = new Button();
            poprawnosc = new Label();
            comboBoxKategoria = new ComboBox();
            button_podpowiedz = new Button();
            label_podpowiedz = new Label();
            label_tytol = new Label();
            label_podtytol = new Label();
            label_stopka = new Label();
            label1 = new Label();
            buttonDodajFiszke = new Button();
            SuspendLayout();
            // 
            // los_slowa
            // 
            los_slowa.Font = new Font("Segoe UI", 13F);
            los_slowa.Location = new Point(353, 193);
            los_slowa.Margin = new Padding(3, 4, 3, 4);
            los_slowa.Name = "los_slowa";
            los_slowa.Size = new Size(186, 56);
            los_slowa.TabIndex = 0;
            los_slowa.Text = "wylosuj słowo";
            los_slowa.UseVisualStyleBackColor = true;
            los_slowa.Click += button1_Click;
            // 
            // wylosowane_slowo
            // 
            wylosowane_slowo.AutoSize = true;
            wylosowane_slowo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            wylosowane_slowo.ForeColor = Color.Black;
            wylosowane_slowo.Location = new Point(333, 150);
            wylosowane_slowo.Name = "wylosowane_slowo";
            wylosowane_slowo.Size = new Size(225, 35);
            wylosowane_slowo.TabIndex = 1;
            wylosowane_slowo.Text = "wylosowane_slowo";
            // 
            // tlumaczenie
            // 
            tlumaczenie.Font = new Font("Segoe UI", 13F);
            tlumaczenie.Location = new Point(320, 257);
            tlumaczenie.Margin = new Padding(3, 4, 3, 4);
            tlumaczenie.Name = "tlumaczenie";
            tlumaczenie.PlaceholderText = "tu wpisać tłumaczenie";
            tlumaczenie.Size = new Size(251, 36);
            tlumaczenie.TabIndex = 2;
            // 
            // sprawdzanie
            // 
            sprawdzanie.Font = new Font("Segoe UI", 13F);
            sprawdzanie.Location = new Point(372, 301);
            sprawdzanie.Margin = new Padding(3, 4, 3, 4);
            sprawdzanie.Name = "sprawdzanie";
            sprawdzanie.Size = new Size(146, 44);
            sprawdzanie.TabIndex = 3;
            sprawdzanie.Text = "sprawdź tłumaczenie";
            sprawdzanie.UseVisualStyleBackColor = true;
            sprawdzanie.Click += sprawdzanie_Click;
            // 
            // poprawnosc
            // 
            poprawnosc.AutoSize = true;
            poprawnosc.Font = new Font("Segoe UI", 13F);
            poprawnosc.Location = new Point(365, 356);
            poprawnosc.Name = "poprawnosc";
            poprawnosc.Size = new Size(153, 30);
            poprawnosc.TabIndex = 4;
            poprawnosc.Text = "czy poprawnie";
            // 
            // comboBoxKategoria
            // 
            comboBoxKategoria.FormattingEnabled = true;
            comboBoxKategoria.Location = new Point(70, 221);
            comboBoxKategoria.Margin = new Padding(3, 4, 3, 4);
            comboBoxKategoria.Name = "comboBoxKategoria";
            comboBoxKategoria.Size = new Size(138, 28);
            comboBoxKategoria.TabIndex = 5;
            // 
            // button_podpowiedz
            // 
            button_podpowiedz.Font = new Font("Segoe UI", 13F);
            button_podpowiedz.Location = new Point(372, 441);
            button_podpowiedz.Margin = new Padding(3, 4, 3, 4);
            button_podpowiedz.Name = "button_podpowiedz";
            button_podpowiedz.Size = new Size(146, 41);
            button_podpowiedz.TabIndex = 6;
            button_podpowiedz.Text = "podpowiedz";
            button_podpowiedz.UseVisualStyleBackColor = true;
            button_podpowiedz.Click += button_podpowiedz_Click;
            // 
            // label_podpowiedz
            // 
            label_podpowiedz.AutoSize = true;
            label_podpowiedz.Font = new Font("Segoe UI", 13F);
            label_podpowiedz.Location = new Point(372, 486);
            label_podpowiedz.Name = "label_podpowiedz";
            label_podpowiedz.Size = new Size(134, 30);
            label_podpowiedz.TabIndex = 7;
            label_podpowiedz.Text = "podpowiedz";
            // 
            // label_tytol
            // 
            label_tytol.AutoSize = true;
            label_tytol.Font = new Font("Segoe UI", 20F);
            label_tytol.Location = new Point(394, 12);
            label_tytol.Name = "label_tytol";
            label_tytol.Size = new Size(93, 46);
            label_tytol.TabIndex = 8;
            label_tytol.Text = "fiszki";
            // 
            // label_podtytol
            // 
            label_podtytol.AutoSize = true;
            label_podtytol.Font = new Font("Segoe UI", 15F);
            label_podtytol.Location = new Point(275, 61);
            label_podtytol.Name = "label_podtytol";
            label_podtytol.Size = new Size(406, 35);
            label_podtytol.TabIndex = 9;
            label_podtytol.Text = "tłumaczenie z angielsiego na polski";
            // 
            // label_stopka
            // 
            label_stopka.AutoSize = true;
            label_stopka.Font = new Font("Segoe UI", 10F);
            label_stopka.Location = new Point(2, 568);
            label_stopka.Name = "label_stopka";
            label_stopka.Size = new Size(756, 23);
            label_stopka.TabIndex = 10;
            label_stopka.Text = "aplikacja do nauki języka angielskiego przez sprawdzanie znajomości tłumaczenia angielskich słów\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(48, 187);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 11;
            label1.Text = "wybrana kategoria";
            // 
            // buttonDodajFiszke
            // 
            buttonDodajFiszke.Location = new Point(712, 512);
            buttonDodajFiszke.Name = "buttonDodajFiszke";
            buttonDodajFiszke.Size = new Size(146, 29);
            buttonDodajFiszke.TabIndex = 12;
            buttonDodajFiszke.Text = "dodaj fiszkę";
            buttonDodajFiszke.UseVisualStyleBackColor = true;
            buttonDodajFiszke.Click += buttonDodajFiszke_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonDodajFiszke);
            Controls.Add(label1);
            Controls.Add(label_stopka);
            Controls.Add(label_podtytol);
            Controls.Add(label_tytol);
            Controls.Add(label_podpowiedz);
            Controls.Add(button_podpowiedz);
            Controls.Add(comboBoxKategoria);
            Controls.Add(poprawnosc);
            Controls.Add(sprawdzanie);
            Controls.Add(tlumaczenie);
            Controls.Add(wylosowane_slowo);
            Controls.Add(los_slowa);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button los_slowa;
        private Label wylosowane_slowo;
        private TextBox tlumaczenie;
        private Button sprawdzanie;
        private Label poprawnosc;
        private ComboBox comboBoxKategoria;
        private Button button_podpowiedz;
        private Label label_podpowiedz;
        private Label label_tytol;
        private Label label_podtytol;
        private Label label_stopka;
        private Label label1;
        private Button buttonDodajFiszke;
    }
}
