using System;
using System.Collections.Generic;

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
        public abstract double Area();
        public abstract double Perimeter();
        public virtual void Print()
        {
            Console.WriteLine(name);
        }
        public int CompareTo(object obj)
        {
            var thisArea = Perimeter();
            var objArea = (obj as Shape).Perimeter();
            return thisArea.CompareTo(objArea);
        }
    }
}
