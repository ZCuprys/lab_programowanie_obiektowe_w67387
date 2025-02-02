using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoriumSharp2
{
    internal class Osoba
    {
        public string Imie;
        public string Nazwisko;
        public int Wiek;

        //Konstruktor
        public Osoba(string imie, string nazwisko, int wiek)
        {
            if (string.IsNullOrWhiteSpace(imie) || imie.Length < 2)
                Console.WriteLine("Imię musi mieć co najmniej 2 znaki.");
            if (string.IsNullOrWhiteSpace(nazwisko) || nazwisko.Length < 2)
                Console.WriteLine("Nazwisko musi mieć co najmniej 2 znaki.");
            if (wiek <= 0)
                Console.WriteLine("Wiek musi być liczbą dodatnią.");

            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }
        // Metoda do wyświetlania informacji o osobie
        public void WyswietlInformacje()
        {
            Console.WriteLine($"Imię: {Imie}, Nazwisko: {Nazwisko}, Wiek: {Wiek}");
        }
    }
}
