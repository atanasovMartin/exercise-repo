using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbertocount = int.Parse(Console.ReadLine());

            var bigestnum = int.MinValue;

            for (int i = 0; i < numbertocount; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number > bigestnum)

                    bigestnum = number;

                 Console.WriteLine(bigestnum);
            }
        }
    }
}
