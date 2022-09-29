using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{


    internal class Program
    {
        static void GetParamcKub(double a, out double s, out double v)
        {
              double s1 = a * a;
              s = s1 * 6;            
              v = a * a * a;
        }
    
        static void Main(string[] args)
        {
        Console.WriteLine("Введите длину ребра куба");
        double a = Convert.ToDouble(Console.ReadLine());
        double s;
        double v;
        GetParamcKub(a, out s, out v);
        Console.WriteLine("Площадь куба S={0:.00}\nОбъем куба V={1:.00}", s,v);
        Console.ReadKey();
        }
    }
}
