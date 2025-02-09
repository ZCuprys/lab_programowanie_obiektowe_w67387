using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03
{
    
    public class Reader : Person
    {
     public List<Book> Przeczytane { get; set; } 
        public Reader(string Imie, string Nazwisko, int Wiek)
            : base(Imie, Nazwisko, Wiek) 
        {
            Przeczytane = new List<Book>();
        
        }

        public void ViewBook() { 

            Console.WriteLine("Lista przeczytanych książek: ");
            if (Przeczytane.Count == 0)
            {
                Console.WriteLine("Brak książek.");
            }
            else
            {
                foreach (var ksiazka in Przeczytane)
                {
                    Console.WriteLine($"{ksiazka.Tytul}");
                }
            }
        }
        public override string View()
        {
            var czytelnikInfo = base.View();
            Console.WriteLine(czytelnikInfo);
            ViewBook();
            return czytelnikInfo;
        }
    }
}
