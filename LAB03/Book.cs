using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03
{
    public class Book 
    {
        public string Tytul {  get; set; }
        public Person Autor { get; set; }
        public DateTime DataWydania { get; set; }

        public Book(string Tytul, Person Autor, DateTime DataWydania)
        {
            this.Tytul = Tytul;
            this.Autor = Autor;
            this.DataWydania = DataWydania;
        }

        public virtual string View()
        {
            return "tytuł: " + Tytul + " " + "Autor: " + Autor.View() + " " + "Data wydania: " + DataWydania.ToShortDateString();
        }
    }
}
