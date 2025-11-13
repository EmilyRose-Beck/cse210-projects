using System;
using System.Collections.Generic;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Console.WriteLine("Shape Area Calculator");
        Console.Write("Please start entering shapes.");

        int count = int.Parse(Console.ReadLine());

        /*
        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);
        */
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nShape #{i + 1}");
            Console.Write("Enter the shape type (square, rectangle, or circle): ");
            string type = Console.ReadLine().ToLower();

            Console.Write("Enter the color: ");
            string color = Console.ReadLine();

            if (type == "square")
            {
                Console.Write("Enter the side length: ");
                double side = double.Parse(Console.ReadLine());
                shapes.Add(new Square(color, side));
            }
            else if (type == "rectangle")
            {
                Console.Write("Enter the length: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter the width: ");
                double width = double.Parse(Console.ReadLine());
                shapes.Add(new Rectangle(color, length, width));
            }
            else if (type == "circle")
            {
                Console.Write("Enter the radius: ");
                double radius = double.Parse(Console.ReadLine());
                shapes.Add(new Circle(color, radius));
            }
            else
            {
                Console.WriteLine("Invalid shape type! Skipping...");
            }
        }

        Console.WriteLine("\n--- Shape Results ---");
        foreach (Shape s in shapes)
        {
           /*
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        */
         Console.WriteLine($"The {s.GetColor()} {s.GetType().Name} has an area of {s.GetArea():0.00}.");
        }
    }
}