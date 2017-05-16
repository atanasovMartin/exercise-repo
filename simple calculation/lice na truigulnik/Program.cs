using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lice_na_truigulnik
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
              
            double h = double.Parse(Console.ReadLine());

            double trianglearea = side * h / 2;
            Math.Round(trianglearea, 2);

            Console.WriteLine("trianglearea = " + trianglearea);

        }
    }
}
