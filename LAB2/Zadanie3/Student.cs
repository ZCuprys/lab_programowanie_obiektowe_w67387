using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    internal class Student
    {
        // get i set
        public string Name { get; private set; }
        public string LastName { get; private set; }

        private List<double> Oceny { get; set; }

        //obliczanie sredniej ocen właściwość

        public double SredniaOcen
        {
            get
            {
                if (Oceny.Count == 0)
                    return 0; //brak ocen
                return Oceny.Average(); //
            }
        }

        public Student(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
            Oceny = new List<double>();
        }

        //metoda do dodania oceny do listy
        public void DodajOcene(double ocena)
        {
            if (ocena < 2 || ocena > 5)
            {
                throw new ArgumentOutOfRangeException("Ocena musi być w zakresie od 2 do 5");
            }
            Oceny.Add(ocena);
        }
        //Metoda wyświetlania informacji o studencie

        public void StudentInfo()
        {
            Console.WriteLine($"Student: {Name} {LastName}");
            Console.WriteLine($"Srednia ocen: {SredniaOcen:F2}");
        }

    }
}

