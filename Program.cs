using System;
using System.Collections.Generic;


namespace Vaderstationen_TinaPhenole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            List<double> tempratureMesh = new List<double>();
            // förprogrammerade tempraturer för listan
            tempratureMesh.Add(10);
            tempratureMesh.Add(15.5);
            tempratureMesh.Add(11.9);
            tempratureMesh.Add(9.4);

            while (showMenu)
            {
                // Lägg till några förinsatta tempraturer
                Console.Clear();
                Console.WriteLine("[L]ägg till mätning");
                Console.WriteLine("[S]kriv ut alla mätningar");
                Console.WriteLine("[M]edelvärde på temperatur");
                Console.WriteLine("[A]vsluta programmet");
                Console.WriteLine("");
                string input = Console.ReadLine().ToUpper();

                switch (input) 
                {
                    case "L":
                        // Lägg till mätning
                        Console.Write("Vilken tempratur vill du lägga till i katalogen? ");
                        string readings = Console.ReadLine();
                        double measurment;
                        try
                        {
                            measurment = Convert.ToDouble(readings);
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Vänligen använd siffror för dina mätningar!");
                            Console.WriteLine("Ingen mätning tillagd");
                            WaitForInput();
                            break;
                        }
                        tempratureMesh.Add(measurment);
                        Console.WriteLine("Du har lagt till: " + measurment + "C, till katalogen");
                        WaitForInput();
                        break;

                    case "S" :
                    // Skriv ut alla mätningar
                    Console.WriteLine("Dina tempraturmätningar: ");
                    foreach (double temp in tempratureMesh)
                    {
                        Console.WriteLine(temp + "C");
                    }
                    WaitForInput();
                    break;

                    case "M" :
                    // Medeltempratur
                       Console.WriteLine("Medel tempraturen är: " + AverageTemprature(tempratureMesh) + "C");
                        WaitForInput();
                    break;

                    case "A" :
                    Console.WriteLine("Programmet stängs");
                    Environment.Exit(0);
                    break;
                    
                    default:
                    Console.WriteLine("Vänligen välj ett av valen från menyn ovanför!");
                    WaitForInput();
                    break;
                }
            
            }
        }
        static double AverageTemprature(List<double> tempratureMesh)
        {
            double sum = 0;
            for (int i = 0; i < tempratureMesh.Count; i++)
            {
                sum = sum + tempratureMesh[i];
            }
            return sum / tempratureMesh.Count;
        }

        private static void WaitForInput()
        {
            Console.WriteLine("Tryck på valfri tangent för att gå till menyn");
            Console.ReadKey();
        }
    }
}