using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    class Triangle : Shape
    {
        public Triangle(int x, int y, int height, int width) : base(x, y, height, width) { }

        public override void Draw()
        {
            Console.WriteLine("Rysowanie trójkąta ", X, Y, Width, Height);
        }
    }
}
