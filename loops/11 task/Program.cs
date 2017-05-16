using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_task
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputT = Console.ReadLine();
            var sum = 0;
            for (int i = 0; i < inputT.Length; i++)
            {
                var s = inputT[i];

                switch (s)
                {
                    case 'a':
                        sum += 1;
                        break;

                    case 'e':
                        sum += 2;
                        break;

                    case 'i':
                        sum += 3;
                        break;

                    case 'o':
                        sum += 4;
                        break;

                    case 'u':
                        sum += 5;
                        break;

                        {
                            

                        }
                       
                }
            }
            Console.WriteLine(sum);
        }
    }
}
y 








