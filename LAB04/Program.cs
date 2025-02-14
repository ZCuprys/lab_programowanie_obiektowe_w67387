using LAB04;

    static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Rectangle(10, 20, 30, 40),
            new Triangle(5, 15, 25, 35),
            new Circle(50, 60, 15)
        };

        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }

