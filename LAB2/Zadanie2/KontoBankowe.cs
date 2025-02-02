using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class KontoBankowe
    {
        // Właściwości
        public string Wlasciciel;
        public decimal Saldo;

        // Konstruktor
        public KontoBankowe(string wlasciciel, decimal poczatkoweSaldo)
        {
            if (string.IsNullOrWhiteSpace(wlasciciel))
            {
                Console.WriteLine("Właściciel nie może być pusty.");
            }
            Wlasciciel = wlasciciel;
            Saldo = poczatkoweSaldo;
        }
        // Metoda do wpłaty środków
        public void Wplata(decimal kwota)
        {
            if (kwota <= 0)
            {
                Console.WriteLine("Kwota musi być dodatnia");
            }   
            if (kwota >= 0)
            {
                Saldo += kwota;
            } 
        }
        //Metoda do wypłaty środków
        public void Wyplata(decimal kwota)
        {
            if (kwota <= 0)
            {
                Console.WriteLine("Kwota wypłaty musi być dodatnia.");
            }
            
            if (kwota > Saldo)
            {
                Console.WriteLine("Niewystarczające środki na koncie.");
            }
            Saldo -= kwota;
        }
    }
}
