using System;
using System.Collections.Generic;
namespace HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Shape> Shapes = new List<Shape>();
            //Shapes.Add(new Circle("Trainee circle", 2));
            //Shapes.Add(new Circle("Junior circle", 3));
            //Shapes.Add(new Circle("Middle circle", 4));
            //Shapes.Add(new Circle("Senior circle", 5));
            //Shapes.Add(new Circle("TeamLead circle", 6));
            //Shapes.Add(new Square("Trainee square", 3));
            //Shapes.Add(new Square("Junior square", 4));
            //Shapes.Add(new Square("Middle square", 5));
            //Shapes.Add(new Square("Senior square", 6));
            //Shapes.Add(new Square("TeamLead square", 7));
            Console.WriteLine("\tTask 1 - set list of Shapes");
            foreach (Shape s in Shapes)
            {
                if (s.GetType() == typeof(Circle) || s.GetType() == typeof(Square))
                {
                    s.Area();
                    s.Perimeter();
                    s.Print();
                }
            }
            Console.WriteLine();
            Shapes.Sort();
            foreach (Shape s in Shapes)
            {
                s.Print();
            }
            Console.ReadLine();
        }
    }
}
