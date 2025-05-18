using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Game
{
    internal class workout
    {
        public static void DoWorkout()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du bist im Fitnessraum, Was möchtest du machen?");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Kniebeugen || Liegestütze");
            Console.ResetColor();

            GetInput();
        }

        private static void GetInput()
        {
            string input = "";
            input = Console.ReadLine();

            while (true)
            {
                if (input == "Kniebeugen")
                    DoSquats();

                else if (input == "Liegestütze")
                    DoPushUps();

                else if (input == "zurück")
                    Program.DoMenu();

                else
                    GetInput();
            }
        }

        private static void DoSquats()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du machst Kniebeugen");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
          
           

            int result = Program.random.Next(1, 101);
            if (result >= 70)
            {
                if (Data.characterData.HealthPoints < 30)
                    Data.characterData.HealthPoints = 0;
                else
                    Data.characterData.HealthPoints -= 30;

                Console.WriteLine("30 LP abgezogen");
            }

            else
            {
                if (Data.characterData.HealthPoints > 90)
                    Data.characterData.HealthPoints = 100;
                else
                    Data.characterData.HealthPoints += 10;

                Console.WriteLine("10 LP hinzugefügt");
            }

            Console.ResetColor();
            System.Threading.Thread.Sleep(5000);
            Data.WriteToConfigData(Data.characterData);

            DoWorkout();
        }

        private static void DoPushUps()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du machst Liegestütze");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

          

            int result = Program.random.Next(1,101);
            if (result >= 80)
            {
                if (Data.characterData.HealthPoints < 40)
                    Data.characterData.HealthPoints = 0;
                else
                    Data.characterData.HealthPoints -= 40;

                Console.WriteLine("40 LP abgezogen");
            }

            else
            {
                if (Data.characterData.HealthPoints > 85)
                    Data.characterData.HealthPoints = 100;
                else
                    Data.characterData.HealthPoints += 15;

                Console.WriteLine("15 LP hinzugefügt");
            }

            Console.ResetColor();
            System.Threading.Thread.Sleep(5000);
            Data.WriteToConfigData(Data.characterData);

            DoWorkout();
        }
    }
}
