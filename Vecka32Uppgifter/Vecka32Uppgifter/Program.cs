using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka32Uppgifter
{
    class Program
    {
        static void Main(string[] args)
        {
            UppgiftTva();
        }

        private static void UppgiftEtt()
        {
            int firstNumber;

            for (firstNumber = 25; firstNumber <= 115; firstNumber += 10)
            {
                Console.WriteLine(firstNumber);
            }

            PressAnyKey();
        }

        private static void UppgiftTva()
        {
            int sum = 0;

            for(int x = 1; x <= 100; x++)
            {
                if (x % 7 == 0)
                {
                    sum += x;
                }
                
            }

            Console.WriteLine("\nSumman av alla tal mellan 1 och 100 som är delbara med 7 är {0}.", sum);
            PressAnyKey();
        }

        private static void PressAnyKey()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
