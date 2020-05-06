using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Point
    {
        public double x, y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Triangle
    {
        public Point a;
        public Point b;
        public Point c;
        public Triangle(double[] x, double[] y)
        {
            this.a = new Point(x[0], y[0]);
            this.b = new Point(x[1], y[1]);
            this.c = new Point(x[2], y[2]);
        }
        public double Area(Triangle abc)
        {
            double result;
            result = Math.Abs((a.x * (b.y - c.y) + b.x * (c.y - a.y) + c.x * (a.y - b.y)) / 2);
            return result;
        }
    }
    class Test
    { 
        public static void Main()
        {
            double[] x = new double[3];
            double[] y = new double[3];
            for(int i = 0; i < 3; ++i)
            {
                Console.Write("\nEnter x"+ i + ": ");
                x[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nEnter y" + i + ": ");
                y[i] = Convert.ToDouble(Console.ReadLine());
            }
            Triangle abc = new Triangle(x, y);
            Console.WriteLine("\nArea = " + abc.Area(abc) + "\n");
            Console.ReadKey();
        }
            
    }
}
