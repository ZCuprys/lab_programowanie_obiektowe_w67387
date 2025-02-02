using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    public class Licz
    {
        private int Value;

        public Licz(int value)
        {
            Value = value;
        }
        public void Dodaj(int liczba)
        {
            Value += liczba;
        }
        public void Odejmij(int liczba)
        {
            Value -= liczba;
        }
        public void WypiszStan()
        {
            Console.WriteLine("Wartość:" + Value);
        }
    }
}
