using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static double Triangle(double a, double b, double c)


        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    
    
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести A, B, C, первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double k1 = Triangle(x1, y1, z1);
            Console.WriteLine("Ввести A, B, C, первого треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double k2 = Triangle(x2, y2, z2);
            if (k1 > k2)
                Console.WriteLine("Площадь первого треугольника больше");
            else
                if (z1 < z2)
                Console.WriteLine("Площадь второго треугольника больше");
            else
                Console.WriteLine("Площадь треугольников одинаковая");
            Console.ReadKey();
        }

    }
}
