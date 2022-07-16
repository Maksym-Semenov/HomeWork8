using System;

namespace HomeWork8
{
    internal class Square : Shape,IComparable<Square>
    {
        private double side;
        private double perimeter;
        public double Side { get { return side; } set { side = value; } }
        public Square(string name) : base(name)
        {
        }
        public override double Perimeter(double side)
        {
            perimeter = (4 * side);
            return perimeter;
        }
        public override void Print()
        {
            Console.WriteLine($"Square's name is {Name}, Perimeter is {perimeter}");
        }
        public int CompareTo(Square other)
        {
            throw new NotImplementedException();
        }
    }
}
