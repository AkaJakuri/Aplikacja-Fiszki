
using fiszki_komendy;

baza_danych baza = new baza_danych();

var wynik = baza.Słowo();
string słowo = wynik.Item1;
string id = wynik.Item2;
Console.WriteLine(słowo);



//Console.WriteLine("Podaj swoje imię:");
//string próba = Console.ReadLine() ?? "";



string próba = "ezz";

bool czy;
czy =baza.sprawdzenie(słowo, id, próba);
Console.WriteLine(czy);