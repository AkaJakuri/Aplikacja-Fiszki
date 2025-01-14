
using fiszki_komendy;

baza_danych baza = new baza_danych();


////losowanie słowa
//var wynik = baza.losowanie_słowa();
//string słowo = wynik.Item1;
//string id = wynik.Item2;
//Console.WriteLine(słowo);






////podanie zdania do słowa po id 
//string zdanie = baza.podaj_zdanie(id);
//Console.WriteLine(zdanie);




////Console.WriteLine("Podaj swoje imię:");
////string próba = Console.ReadLine() ?? "";
///
//string próba = "ezz";

//bool czy;

//czy =baza.sprawdzenie(słowo, id, próba);
//Console.WriteLine(czy);





//wypisanie wszystkich kategorii 

//Dictionary<int,string> kategorie = new Dictionary<int,string>();
//kategorie = baza.lista_kategorii();

//foreach (var k in kategorie)
//{
//    Console.WriteLine($"{k.Key}, {k.Value}");
//}






//dodanie nowej fiszki 
//baza.dodanie_fiszki("banana", "banan", "I ate a banana for breakfast.", 2, 1);




List<baza_danych.Fiszka> fiszki = new List<baza_danych.Fiszka>();

//List<baza_danych.Fiszka> listaFiszek = baza.wypisz_fiszli();

fiszki = baza.wypisz_fiszki();

foreach(var i in fiszki)
{
    Console.WriteLine($"{i.Id}, {i.Slowo}, {i.Tlumaczenie}, {i.ZdaniePrzyklad}, " +
        $"{i.KategoriaID}, {i.PoziomTrudnosciId}");
}

fiszki = baza.wypisz_fiszki(2);
Console.WriteLine("---------------------");
foreach (var i in fiszki)
{
    Console.WriteLine($"{i.Id}, {i.Slowo}, {i.Tlumaczenie}, {i.ZdaniePrzyklad}, " +
        $"{i.KategoriaID}, {i.PoziomTrudnosciId}");
}