using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mini_Game
{
    public class Program
    {
        public static Random random = new Random(Convert.ToInt32($"{DateTime.Now.Minute}{DateTime.Now.Second}{DateTime.Now.Millisecond}"));

        static void Main(string[] args)
        {
            Data.ReadConfigDataStrings();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Herzlich Willkommen im Mini_Game!!!\nLebenspunkte: {Data.characterData.HealthPoints}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Zum Starten schreibe START");
            Console.ResetColor();

            GetInput();
        }

        public static void GetInput()
        {
            string input = "";
            input = Console.ReadLine();

            while (true)
            {
                if (input == "START")
                    DoMenu();

                else if (input == "schlafen")
                    DoSleep();

                else if (input == "arbeiten")
                    Work.DoMenu();

                else if (input == "essen")
                    Eat.DoEat();

                else if (input == "sport")
                    workout.DoWorkout();

                else if (input == "char")
                    DoChar();

                else if (input == "zurück")
                    DoMenu();

                else if (input == "EXIT" || input == "QUIT")
                    Environment.Exit(0);

                else
                    GetInput();
            }
        }

        public static void DoMenu()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Was möchtest du tuhen?");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("arbeiten || schlafen || essen || sport || char || EXIT");
            Console.ResetColor();

            GetInput();
        }

        private static void DoSleep()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du schläfst 8 Stunden und regenerierst deine Energielevel und bist Top Fit");
            Console.ResetColor();

            System.Threading.Thread.Sleep(5000);


            if (Data.characterData.HealthPoints > 90)
                Data.characterData.HealthPoints = 100;
            else
                Data.characterData.HealthPoints += 10;

            Data.WriteToConfigData(Data.characterData);

            DoMenu();
        }

        private static void DoChar()
        {
            Console.Clear();

            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine($"Dein Char hat: {Data.characterData.HealthPoints} Lebenspunkte");
            Console.ResetColor();

            GetInput();
        }

       
    }
}
