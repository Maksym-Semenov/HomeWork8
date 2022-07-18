﻿using System;
using System.Collections;
using System.Collections.Generic;
namespace HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Shapes = new List<Shape>();
            Shapes.Add(new Circle("Trainee circle", 2));
            Shapes.Add(new Circle("Junior circle", 3));
            Shapes.Add(new Circle("Middle circle", 4));
            Shapes.Add(new Circle("Senior circle", 5));
            Shapes.Add(new Circle("TeamLead circle", 6));
            Shapes.Add(new Square("Trainee square", 3));
            Shapes.Add(new Square("Junior square", 4));
            Shapes.Add(new Square("Middle square", 5));
            Shapes.Add(new Square("Senior square", 6));
            Shapes.Add(new Square("TeamLead square", 7));
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

            Console.WriteLine("\tTask 2 - Biggest Perimeter");
            double perimeterMax = Shapes[0].Perimeter();
            string name = null;
            foreach (Shape s in Shapes)
            {
                if (s.Perimeter() > perimeterMax)
                {
                    perimeterMax = s.Perimeter();
                    name = s.Name;
                }
                else
                    continue;
            }
            Console.WriteLine($"Shape {name} has the biggest perimeter");
            Console.WriteLine();

            Console.WriteLine("\tTask 3 - sorted by area");
            Shapes.Sort();
            foreach (Shape s in Shapes)
            {
                s.Print();
            }
            Console.ReadLine();
        }
    }
}