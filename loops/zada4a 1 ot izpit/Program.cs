using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a_1_ot_izpit
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var p1 = 0;
            var p2 = 0;
            var p3 = 0;
            var p4 = 0;
            var p5 = 0;

            for (int i = 0; i < n; i++)
            {
                var chislo = int.Parse(Console.ReadLine());


                if (chislo < 200)
                {
                    p1++;
                }
                else if (chislo < 400)
                {
                    p2++;
                }
                else if (chislo < 600)
                {
                    p3++;
                }
                else if (chislo < 800)
                {
                    p4++;
                }
                else 
                {
                    p5++;
                }

            }

            var procent1 = p1 * 100.0  /n;
            var procent2 = p2 * 100.0 / n;
            var procent3 = p3 * 100.0 / n; 
            var procent4 = p4 * 100.0 / n;
            var procent5 = p5 * 100.0/ n;

            Console.WriteLine("p1 = {0:f2}%", procent1);
            Console.WriteLine("p2 = {0:f2}%", procent2);
            Console.WriteLine("p3 = {0:f2}%", procent3);
            Console.WriteLine("p4 = {0:f2}%", procent4);
            Console.WriteLine("p1 = {0:f2}%", procent5);
        }
    }
}