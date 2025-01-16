using Microsoft.Data.SqlClient;

namespace fiszki_aplikacja_okienkowa
{
    public partial class Form1 : Form
    {
        private Baza_danych baza;

        string id;
        string s這wo;




        public Form1()
        {
            InitializeComponent();
            baza = new Baza_danych();

            // Za豉duj dost瘼ne kategorie do ComboBoxa
            var kategorie = baza.lista_kategorii();

            // Dodaj "Wszystkie kategorie" na pocz靖ek listy
            var wszystkieKategorie = new KeyValuePair<int, string>(0, "Wszystkie kategorie");
            kategorie.Add(wszystkieKategorie.Key, wszystkieKategorie.Value);

            // Ustaw dane w ComboBox
            comboBoxKategoria.DataSource = new BindingSource(kategorie, null);
            comboBoxKategoria.DisplayMember = "Value";
            comboBoxKategoria.ValueMember = "Key";


        }


        private void los_s這wa()
        {
            var wybranaKategoria = (KeyValuePair<int, string>)comboBoxKategoria.SelectedItem;
            int kategoriaId = wybranaKategoria.Key;


            var wynik = baza.losowanie_s這wa(kategoriaId);
            s這wo = wynik.Item1;
            id = wynik.Item2;
            wylosowane_slowo.Text = s這wo;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            los_s這wa();
        }

        private void sprawdzanie_Click(object sender, EventArgs e)
        {
            string tlumacz = tlumaczenie.Text;
            bool czy = baza.sprawdzenie(s這wo, id, tlumacz);
            if (czy)
            {
                los_s這wa();
                label_podpowiedz.Text = "podpowiedz";
                poprawnosc.Text = "poprawne t逝maczenie";
                poprawnosc.ForeColor = Color.Green;
                tlumaczenie.Text = "";

            }
            else
            {
                poprawnosc.Text = "nie poprawnie";
                poprawnosc.ForeColor = Color.Red;
            }

        }

        private void button_podpowiedz_Click(object sender, EventArgs e)
        {
            string zdanie = baza.podaj_zdanie(id);


            label_podpowiedz.Text = zdanie;
        }


    }
}
