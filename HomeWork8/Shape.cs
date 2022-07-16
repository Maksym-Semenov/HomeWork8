using System;

namespace HomeWork8
{
    internal abstract class Shape : IComparable
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
        public Shape(string name)
        {
            this.name = name;
        }
       
        public virtual double Area(double a)
        {
            return a;
        }
        public virtual double Perimeter(double a)
        {
            return a;
        }
        public virtual void Print()
        {
            Console.WriteLine(name);
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
