using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    class Circle : Shape
    {
        public Circle(int x, int y, int radius) : base(x, y, radius * 2, radius * 2) { }

        public override void Draw()
        {
            Console.WriteLine("Rysowanie koła ", X, Y, Width / 2);
        }
    }
}
