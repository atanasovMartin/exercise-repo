using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_Rectangele
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var sidea = Math.Abs(x1 - x2);

            var sideb = Math.Abs(y1 - y2);

            var area = sidea * sideb;

            var perimetur = 2 * (sidea + sideb);



            Console.WriteLine("Area " + area);

            Console.WriteLine("Perimetur " + perimetur);
        }
    }
}
