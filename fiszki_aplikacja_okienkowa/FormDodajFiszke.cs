using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fiszki_aplikacja_okienkowa
{
    public partial class FormDodajFiszke : Form
    {
        private Baza_danych baza;
        public FormDodajFiszke()
        {
            InitializeComponent();
            baza = new Baza_danych();
        }

        private void FormDodajFiszke_Load(object sender, EventArgs e)
        {
            comboBoxKategoria.DataSource = new BindingSource(baza.lista_kategorii(), null);
            comboBoxKategoria.DisplayMember = "Value";
            comboBoxKategoria.ValueMember = "Key";


            Dictionary<int, string> poziomy = new Dictionary<int, string>()
            {
                { 1, "A1" },
                { 2, "A2" },
                { 3, "B1" },
                { 4, "B2" },
                { 5, "C1" },
                { 6, "C2" }
            };

            comboBoxPoziom.DataSource = new BindingSource(poziomy, null);
            comboBoxPoziom.DisplayMember = "Value";
            comboBoxPoziom.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string slowo = textBoxSlowo.Text;
            string tlumaczenie = textBoxTlumaczenie.Text;
            string zdanie = textBoxZdanie.Text;

            if (int.TryParse(comboBoxKategoria.SelectedValue?.ToString(), out int kategoriaID) &&
                int.TryParse(comboBoxPoziom.SelectedValue?.ToString(), out int poziomTrudnosciID))
            {
                baza.dodanie_fiszki(slowo, tlumaczenie, zdanie, kategoriaID, poziomTrudnosciID);
                MessageBox.Show("Fiszka została dodana!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Wybierz poprawne wartości dla kategorii i poziomu trudności.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
