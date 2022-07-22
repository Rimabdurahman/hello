using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes1
{
    public abstract class shape
    {
        public abstract double calculate_Area();
        public abstract double calculate_Perimeter();

    }

    class circle : shape
    {
        static readonly double PI = 3.14;
        
        public double radius { get; set; }
        public override double calculate_Area()
        {
            return PI * radius * radius;
        }
        public override double calculate_Perimeter()
        {
            return 2 * PI * radius;
        }
    }
    class rectangle : shape
    {
        public double length { get; set; }
        public double width { get; set; }
        public override double calculate_Area()
        {
            return length * width;
        }
        public override double calculate_Perimeter()
        {
            return (2 * length) + (2 * width);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle();
            rectangle rec = new rectangle();
            int choice;
            Console.WriteLine("Enter 1 for Circle");
            Console.WriteLine("Enter 2 for Rectangle");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                double r;
                Console.WriteLine("Enter radius of circle");
                r = double.Parse(Console.ReadLine());
                c.radius = r;
                Console.WriteLine("Area of circle is " + c.calculate_Area());
                Console.WriteLine("Perimeter of circle is " + c.calculate_Perimeter());


            }
            else if (choice == 2)
            {
                double l, w;
                Console.WriteLine("Enter length of rectangle");
                l = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter width of rectangle");
                w = double.Parse(Console.ReadLine());
                rec.length = l;
                rec.width = w;
                Console.WriteLine("Area of Rectangle is " + rec.calculate_Area());
                Console.WriteLine("Perimeter of Rectangle is " + rec.calculate_Perimeter());

            }
        }
    }
}
