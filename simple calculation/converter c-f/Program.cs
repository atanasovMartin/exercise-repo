using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter_c_f
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = double.Parse(Console.ReadLine());

            var rezult = C *1.8 + 32;

            Math.Round(rezult, 2);

                Console.WriteLine(rezult);


        }
    }
}
