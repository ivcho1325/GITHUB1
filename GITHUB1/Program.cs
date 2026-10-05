using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GITHUB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("this is the first github test");
            Console.WriteLine("test");*/

            Console.WriteLine("vuvedi strana a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("vuvedi strana b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("vuvedi strana c");
            double c = double.Parse(Console.ReadLine());

            double D = b * b - 4 * a * c;
            Console.WriteLine("Discriminant: {0}", D);
            double Disk = Math.Sqrt(D);
            
            double x1 = (-b + Disk) / (2 * a);
            double x2 = (-b - Disk) / (2 * a);
            Console.WriteLine("Roots:sa:x1 = x2);


        }
    }
}