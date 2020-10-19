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
            while (showMenu)
            {
                showMenu = MainMenu();
            }
            // Meny 
            static bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("[L]ägg till mätning");
                Console.WriteLine("[S]kriv ut alla mätningar");
                Console.WriteLine("[M]edelvärde på temperatur");
                Console.WriteLine("[A]vsluta programmet");
                // sammankoppling behövs!

                switch (Console.ReadKey().ToUpper) 
                {
                    case 1: 
                    // Lägg till mätning
                    Console.Write("Vilken tempratur vill du lägga till i katalogen?");
                    string readings = Console.ReadLine();
                    double measurment = Convert.ToDouble(readings);
                    tempratureMesh.Add(measurment);
                    Console.WriteLine("Du har lagt till: " + measurment + " till katalogen");
                    return true;

                    case 2:
                    //Skriv ut alla mätningar
                    Console.WriteLine("Dina tempraturmätningar: ");
                    Console.WriteLine(tempratureMesh);
                    return true;

                    case 3:
                    // Medeltempratur
                    AverageTemprature();
                    return true;

                    case 4:
                    Console.WriteLine("Programmet stängs");
                    Environment.Exit(0);
                    return false;
                    
                    default:
                    Console.WriteLine("Vänligen välj ett av valen från menyn ovanför!"); // Kan göras tydligare
                    return true;
                }
            
            }
            
            static double AverageTemprature()
            {
                double sum = 0.0f;
                for (double i = 0; i < tempratureMesh.Count; i++)
                {
                    sum = sum + tempratureMesh[i];
                }
                Console.WriteLine("Medel tempraturen är: " + sum / tempratureMesh.Count);
            }
            // Lägg till mätning list<double>
            // Skriv ut alla mätningar print list<>
            // Medelvärde på tempraturer for loop sum / antal
            // Avsluta System.Exit(o)
        }
    }
}