using System;

public class Osoba
{
    public string Imie { get; private set; }
    public string Nazwisko { get; private set; }
    public string Plec { get; private set; } //  pełne słowo
    public DateTime DataUrodzenia { get; private set; }

    public Osoba(string imie, string nazwisko, string plec, DateTime dataUrodzenia)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Plec = plec.ToLower() == "mężczyzna" ? "Mężczyzna" : "Kobieta";
        DataUrodzenia = dataUrodzenia;
    }


    public void WyswietlInformacje()
    {
        Console.WriteLine($"Imię: {Imie}, Nazwisko: {Nazwisko}, Płeć: {Plec}, Data Urodzenia: {DataUrodzenia.ToShortDateString()}");
    }
}
