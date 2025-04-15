using System;

class Program
{
    static void Main(string[] args)
    {

         List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Green", 2.0);
        Rectangle r1 = new Rectangle("Red", 4.0, 5.0);
        Circle c1 = new Circle("Blue", 3.0);

        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        foreach (Shape shape in shapes)
        {
            DisplayInformation(shape);
        }
    }

    public static void DisplayInformation(Shape shape)
    {
        Console.WriteLine($"This is a {shape.GetColor()} {shape.GetType().Name} with an area of {shape.GetArea()}");
    }
}