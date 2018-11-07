﻿using System;
using System.Collections.Generic;
using System.Linq;


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

        private static void UppgiftSex()
        {
            int one;
            int two;
            int sum;
            int product;
            int average;

            try
            {
                Console.WriteLine("\nEnter first int:");
                one = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter second int:");
                two = Convert.ToInt32(Console.ReadLine());

                sum = one + two;
                product = one * two;
                average = (one + two) / 2;

                Console.WriteLine("Sum: {0}", sum);
                Console.WriteLine("Average: {0}", average);
                Console.WriteLine("Product: {0}", product);

                if (one > two)
                {
                    Console.WriteLine("Number One is larger!");
                }
                
                else if (one < two)
                {
                    Console.WriteLine("Number Two is larger!");
                }

                else if (one == two)
                {
                    Console.Write("Number One and Two are equal!");
                }


                PressAnyKey();

            }

            catch(Exception)
            {
                Console.WriteLine("\n\nSomething went wrong. ¯|_(ツ)_/¯");
                UppgiftSex();
            }







        }

        private static void UppgiftSju()
        {
            int betygEtt;
            int betygTwo;
            int betygTre;
            int betygFyra;
            int betygFem;

            betygEtt = Convert.ToInt32(Console.ReadLine());
            betygTwo = Convert.ToInt32(Console.ReadLine());
            betygTre = Convert.ToInt32(Console.ReadLine());
            betygFyra = Convert.ToInt32(Console.ReadLine());
            betygFem = Convert.ToInt32(Console.ReadLine());

            int[] betyg = new int[] { betygEtt, betygTwo, betygTre, betygFyra, betygFem };


            IEnumerable<int> betygQuery =
                from b in betyg
                where b > 49
                select b;


            foreach (int i in betygQuery)
            {
                Console.Write(i + " ");
            }

            PressAnyKey();



            

            
        } // Egentligen också uppgift 6 men du råkade skriva uppgift 6 två gånger

        private static void UppgiftAtta() // Egentligen uppgift sju fast pga du skrev uppgift 6 två gånger så blev det 8
        {
            int[] hastigheter = new int[] { 55, 64, 50, 62, 45, 0 };

            Console.WriteLine("\nBilhastigheter i Km/h \n");
            foreach (int hastighet in hastigheter)
            {
                Console.WriteLine(hastighet);
            }

            hastigheter = hastigheter.Where(x => x != 0).ToArray(); // Använder LINQ för att tabort 0


            int hogstaHastighet = hastigheter.Max();
            int lagstaHastighet = hastigheter.Min();
            int summa = hastigheter.Sum();
            int medelHastighet = summa / hastigheter.Length;


            Console.WriteLine("\n\n");
            Console.WriteLine("Högsta hastighet: {0}", hogstaHastighet);
            Console.WriteLine("Lägsta hastighet: {0}", lagstaHastighet);
            Console.WriteLine("Medel hastighet: {0}", medelHastighet);

            PressAnyKey();


        }

        private static void SelectionMenu()
        {
            Console.WriteLine("Enter selection:");

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
                case ("uppgiftsex"):
                    UppgiftSex();
                    break;
                case ("uppgiftsju"):
                    UppgiftSju();
                    break;
                case ("uppgiftåtta"):
                    UppgiftAtta();
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
