using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leftright_side
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var leftside = 0;

            var rightside = 0;

            for (int i = 0; i < n; i++)

            {
                var num = int.Parse(Console.ReadLine());

                leftside += num;
            }

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                rightside += num;

                if (leftside == rightside)

                {
                    Console.WriteLine("Yes sum = {0}", leftside);
                }
                else
                {
                Console.WriteLine("NO diff = {0}", Math.Abs(leftside - rightside));

                }
            }
        }
    }
}
