using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rad_to_degree
{
    class Program
    {
        static void Main(string[] args)
        {

            double rad = double.Parse(Console.ReadLine());

            var degree = rad * 57.29578;



            Console.WriteLine(Math.Round(degree, 2));

        }
    }
}
