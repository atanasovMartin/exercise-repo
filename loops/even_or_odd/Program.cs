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

            var evenSum = 0;

            var oddSum = 0;

            for (int i = 0; i < n; i++)

            {
                var num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    oddSum += num;
                }

                for (int i = 0; i < n; i++)

                {
                    var number = int.Parse(Console.ReadLine());
                
                    oddSum += number;
                }
                

                    if (oddSum == evenSum)

                    {
                        Console.WriteLine("Yes sum = {0}", evenSum);
                    }
                    else
                    {
                        Console.WriteLine("NO diff = {0}", Math.Abs(evenSum - oddSum));

                    }
                }
            }
        }


