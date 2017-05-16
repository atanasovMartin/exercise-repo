using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var USDtoBGN = 1.79549;
            var EURtoBGN = 1.95583;
            var GBPtoBGN = 2.53405;

            var cash = double.Parse(Console.ReadLine());
            var inputC = Console.ReadLine();
            var OutputC = Console.ReadLine();

            if (inputC != "BGN")
            {
                if (inputC == "USD")

                    cash *= USDtoBGN;

                else if (inputC == "EUR")

                    cash *= EURtoBGN;

                else //inputc == GBP

                    cash *= GBPtoBGN;
            }

           
            {
                if (OutputC == "USD")

                    cash /= USDtoBGN;

                else if (OutputC == "EUR")

                    cash /= EURtoBGN;

                else if (OutputC == "GBP")

                    cash /= GBPtoBGN;

                Console.WriteLine("{0:F2} {1}", cash, OutputC );

            }
        }
    }
}