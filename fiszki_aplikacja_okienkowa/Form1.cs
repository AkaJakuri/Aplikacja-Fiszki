using Microsoft.Data.SqlClient;

namespace fiszki_aplikacja_okienkowa
{
    public partial class Form1 : Form
    {
        private Baza_danych baza;

        string id;
        string s�owo;




        public Form1()
        {
            InitializeComponent();
            baza = new Baza_danych();

            // Za�aduj dost�pne kategorie do ComboBoxa
            var kategorie = baza.lista_kategorii();

            // Dodaj "Wszystkie kategorie" na pocz�tek listy
            var wszystkieKategorie = new KeyValuePair<int, string>(0, "Wszystkie kategorie");
            kategorie.Add(wszystkieKategorie.Key, wszystkieKategorie.Value);

            // Ustaw dane w ComboBox
            comboBoxKategoria.DataSource = new BindingSource(kategorie, null);
            comboBoxKategoria.DisplayMember = "Value";
            comboBoxKategoria.ValueMember = "Key";


        }


        private void los_s�owa()
        {
            var wybranaKategoria = (KeyValuePair<int, string>)comboBoxKategoria.SelectedItem;
            int kategoriaId = wybranaKategoria.Key;


            var wynik = baza.losowanie_s�owa(kategoriaId);
            s�owo = wynik.Item1;
            id = wynik.Item2;
            wylosowane_slowo.Text = s�owo;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            los_s�owa();
        }

        private void sprawdzanie_Click(object sender, EventArgs e)
        {
            string tlumacz = tlumaczenie.Text;
            bool czy = baza.sprawdzenie(s�owo, id, tlumacz);
            if (czy)
            {
                los_s�owa();
                label_podpowiedz.Text = "podpowiedz";
                poprawnosc.Text = "poprawne t�umaczenie";
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
