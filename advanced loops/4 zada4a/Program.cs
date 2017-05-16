using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 0; i < n; i += 2)
            {
                
                num = num * 2 * 2;
            }

               Console.WriteLine(num);
        }
    }
}
