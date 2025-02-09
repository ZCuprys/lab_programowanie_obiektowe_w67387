using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03
{
    public class Person
    {
        private string Imie { get; set; }
        private string Nazwisko { get; set; }
        private int Wiek { get; set; }

        public Person(string Imie, string Nazwisko, int Wiek)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Wiek = Wiek;
        }
        public virtual string View()
        {
            return Imie + " " + Nazwisko + " " + "wiek:" + Wiek;
        }
    }
}
