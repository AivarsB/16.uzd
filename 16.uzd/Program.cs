using System;

namespace _16.uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vai tu gribi pusdienas? TRUE-Jaa, FALSE-Nee");
            string userInput = Console.ReadLine();

            if (userInput == "true" || userInput == "false" || userInput == "TRUE" || userInput == "FALSE")

            {
                bool answer = bool.Parse(userInput);

                if (answer)
                {
                    Console.WriteLine("Jusu pusdienas ir gatavas");
                }

                else if (!answer)
                {
                    Console.WriteLine("Jums pusdienas nebuus");

                }
            }

            else
            {
                Console.WriteLine("Nepareiza atbilde");

            }
        }
    }
}


// Izveidot console aplikāciju, kura paprasa lietotājam vai viņš grib pusdienas. 
// Ja lietotājs ir ievadījis TRUE, tad uz ekrāna izdrukāt "Jūsu pusdienas ir gatavas", 
// ja lietotājs ir ievadījis FALSE, tad "Jums pusdienas nebūs". 
// IF ELSE nosacījumā ir jāizmanto bool tipa mainīgais, nevis string tipa mainīgais. 
// Lai no lietotāja ievadītā teksta iegūtu bool tipa mainīgo ir jāizmanto bool.Parse, līdzīgi kā ar konvertēšanu uz veselu skaitli.

