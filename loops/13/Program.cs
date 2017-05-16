using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            var oddMin = int.MaxValue;

            var oddMax = int.MinValue;

            var oddSum = 0.0;

            var evenMin = int.MaxValue;

            var evenMax = int.MinValue;

            var evenSum = 0.0;

            for (double i = 1; i < n; i++)
            {
                var chislo = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    oddSum += chislo;

                    if (chislo > oddMax)
                    {
                        oddMax = chislo;
                    }
                    else if (chislo < oddMin)
                    {
                        oddMin = chislo;
                    }
                    }
                    
                    } 
                }


            }
        }
    }
}
