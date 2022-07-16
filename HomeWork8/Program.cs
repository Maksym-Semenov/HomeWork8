using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Shape> Shapes = new List<Shape>();
            Shapes.Add(new Circle("Trainee circle"));
            Shapes.Add(new Circle("Junior circle"));
            Shapes.Add(new Circle("Middle circle"));
            Shapes.Add(new Circle("Senior circle"));
            Shapes.Add(new Circle("TeamLead circle"));
            Shapes.Add(new Square("Trainee square"));
            Shapes.Add(new Square("Junior square"));
            Shapes.Add(new Square("Middle square"));
            Shapes.Add(new Square("Senior square"));
            Shapes.Add(new Square("TeamLead square"));
            int i = 2;
            foreach (Shape s in Shapes)
            {
                if (s.GetType() == typeof(Circle))
                {
                    s.Area(i);
                    s.Print();
                }
                i++;
            }
            int j = 3;
            foreach (Shape s in Shapes)
            {
                if (s.GetType() == typeof(Square))
                {
                    s.Perimeter(j);
                    s.Print();
                }
                j++;
            }
           
            Console.ReadLine();
        }
    }
}
