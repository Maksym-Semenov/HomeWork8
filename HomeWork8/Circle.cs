using System;

namespace HomeWork8
{
    internal class Circle : Shape,IComparable<Circle>
    {
        private double radius;
        private double area;
        public double Radius { get { return radius; } set { radius = value; } }
        public Circle(string name) : base(name)
        {
        }
        public override double Area(double radius)
        {
            area = Math.Round((Math.PI * Math.Pow(radius, 2)), 2);
            return area;
        }
        public override void Print()
        {
            Console.WriteLine($"Circle's name is {Name}, Area = {area}");
        }
        public int CompareTo(Circle other)
        {
            throw new NotImplementedException();
        }
    }
}
