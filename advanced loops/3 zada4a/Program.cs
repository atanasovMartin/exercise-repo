using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 1;

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(sum);
                sum = sum * 2;
            }
               
        }
    }
}
