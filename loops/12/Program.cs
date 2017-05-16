using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;
            var max = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }


            if (max == sum - max)

            {
                Console.WriteLine("YES");
                Console.WriteLine("sum = {0}", max);

            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("diff = {0}",Math.Abs(max -(sum - max)));
            }


        }
    }
}
