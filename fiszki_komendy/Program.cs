
using fiszki_komendy;

baza_danych baza = new baza_danych();

var wynik = baza.losowanie_słowa();
string słowo = wynik.Item1;
string id = wynik.Item2;
Console.WriteLine(słowo);

string zdanie = baza.podaj_zdanie(id);
Console.WriteLine(zdanie);

//Console.WriteLine("Podaj swoje imię:");
//string próba = Console.ReadLine() ?? "";

string próba = "ezz";

bool czy;
czy =baza.sprawdzenie(słowo, id, próba);
Console.WriteLine(czy);


Dictionary<int,string> kategorie = new Dictionary<int,string>();
kategorie = baza.lista_kategorii();


foreach (var k in kategorie)
{
    Console.WriteLine($"{k.Key}, {k.Value}");
}