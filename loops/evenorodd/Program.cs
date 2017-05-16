using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenorodd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var evensum = 0;

            var oddsum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                  oddsum += number;
                }
                else evensum += number;

                if (evensum == oddsum)
                {
                    Console.WriteLine("yes = {0}", oddsum);
                }
                else
                {
                    Console.WriteLine("NO diff = {0}", Math.Abs(evensum - oddsum));
                 }
                    


            }



        }

    }
}


