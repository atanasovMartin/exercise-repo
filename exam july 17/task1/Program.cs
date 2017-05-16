using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {

            var bitCount = int.Parse(Console.ReadLine());
            var chinaCount = int.Parse(Console.ReadLine());
            var comissionCount = int.Parse(Console.ReadLine());

            var priceBit = 1168;
            var priceCny = 0.15 * 1.76;
            var usd = 1.76;
            var euro = 1.95;

            var sum = (bitCount * priceBit) + (chinaCount * priceCny) / 1.95;

            var comission = (comissionCount * sum) / 100;
            var rezult = sum - comission;
            Console.WriteLine(rezult);


        }
    }
}

