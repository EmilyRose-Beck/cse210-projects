using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Console.WriteLine("Welcome to the Shape Area Calculator!");

        bool addMore = true;

        //next put lines 15-56 into a class or functon
        while (addMore)
        {
            Console.WriteLine("\nAdd a new shape!");
            Console.Write("Enter the shape type (square, rectangle, or circle): ");
            string type = Console.ReadLine().Trim().ToLower();

            Console.Write("Enter the color: ");
            string color = Console.ReadLine().Trim();

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

            Console.Write("\nWould you like to add another shape? (yes/no): ");
            string response = Console.ReadLine().Trim().ToLower();

            if (response != "yes" && response != "y")
            {
                addMore = false;
            }
        }

        Console.WriteLine("\n--- Shape Results ---");
        foreach (Shape s in shapes)
        {
            Console.WriteLine($"The {s.GetColor()} {s.GetType().Name} has an area of {s.GetArea():0.00}.");
        }

        Console.WriteLine("\nThanks for using the Shape Area Calculator!");
    }
}
