using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circlearea
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var Area = Math.PI * r * r;
            var Perimetur = 2 * Math.PI * r;
            Console.WriteLine("Area = " + Area);
            Console.WriteLine("Perimetur = " + Perimetur);

        }
    }
}
