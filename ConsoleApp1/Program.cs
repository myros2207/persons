using System;

class Program
{
    static void Main()
    {
        Osoba osoba = new Osoba("Anna", "Nowak", "kobieta", new DateTime(1985, 7, 20));
        osoba.WyswietlInformacje();

        // Dodanie kolejnej osoby
        Osoba innaOsoba = new Osoba("Paweł", "Kowalski", "mężczyzna", new DateTime(1992, 11, 15));
        innaOsoba.WyswietlInformacje();
    }
}

