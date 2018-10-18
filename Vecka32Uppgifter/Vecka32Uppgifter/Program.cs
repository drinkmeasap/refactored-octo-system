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
            UppgiftEtt();
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

        private static void PressAnyKey()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
