using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var evenSum = 0;

            var oddSum = 0;

            for (int i = 0; i < n; i++)

            {
                var num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)

                    oddSum += num;

                else

                    evenSum += num;

            }


            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes sum = {0}", evenSum);

            }
            else
            {
                Console.WriteLine("No diff = {0}", Math.Abs(evenSum - oddSum));
            }


        }


    }
}

