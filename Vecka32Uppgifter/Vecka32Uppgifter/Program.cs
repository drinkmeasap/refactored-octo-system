using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vecka32Uppgifter
{
    class Program
    {
        
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

        private static void UppgiftTre()
        {
            int minutes;
            int hour;
            int minutesResult;

            Console.WriteLine("Enter amount of minutes:");

            minutes = Convert.ToInt32(Console.ReadLine());

            hour = minutes / 60;
            minutesResult = minutes % 60;

            Console.WriteLine("{0} minut(er) blir: {1} timme(ar) och {2} minut(er).",minutes ,hour, minutesResult);


            PressAnyKey();
        }

        private static void UppgiftFyra()
        {
            int month;
            int year;
            int result;


            Console.WriteLine("Enter amount of months:");
            month = Convert.ToInt32(Console.ReadLine());
            year = month / 12;
            result = month % 12;
            Console.WriteLine("{0} månad(er) blir: {1} år och {2} månad(er).", month, year, result);
            PressAnyKey();

        }

        private static void UppgiftFem()
        {

            string euroInput;
            decimal euro;
            decimal kronor;
            string kronorInput;
            decimal result;

            Console.WriteLine("\nEnter value of Euro:");
            euroInput = Console.ReadLine();

            Console.WriteLine("\nEnter amount of kronor:");
            kronorInput = Console.ReadLine();

            try
            {
                euro = Decimal.Parse(euroInput);
                kronor = Decimal.Parse(kronorInput);
                result = kronor / euro;
                Console.WriteLine("\n\n{0} kronors is around {1} euro.",kronor, Math.Round(result));
                PressAnyKey();
            }

            catch (System.FormatException)
            {
                Console.WriteLine("Format exception!\n\n\n\n");
                UppgiftFem();
            }

            

        }

        private static void SelectionMenu()
        {
            string selection;
            selection = Console.ReadLine();
            selection = selection.ToLower();

            switch (selection)
            {
                case ("uppgiftett"):
                    UppgiftEtt();
                    break;
                case ("uppgifttvå"):
                    UppgiftTva();
                    break;
                case ("uppgifttre"):
                    UppgiftTre();
                    break;
                case ("uppgiftfyra"):
                    UppgiftFyra();
                    break;
                case ("uppgiftfem"):
                    UppgiftFem();
                    break;
                case ("exit"):
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    SelectionMenu();
                    break;
            }

        }

        private static void PressAnyKey()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            SelectionMenu();
        }

    }
}
