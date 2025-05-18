using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Game
{
    internal class Eat
    {
        public static void DoEat()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du bist in der Küche, was möchtest du essen?");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Apfel || Banane || Schokolade || Pizza");
            Console.ResetColor();

            GetInput();
        }

        private static void GetInput()
        {
            string input = "";
            input = Console.ReadLine();

            while (true)
            {
                if (input == "Apfel")
                    DoEatApple();

                else if (input == "Banane")
                    DoEatBanana();

                else if (input == "Schokolade")
                    DoEatChoclat();

                else if (input == "Pizza")
                    DoEatPizza();

                else if (input == "zurück")
                    Program.DoMenu();

                else
                    GetInput();
            }
        }

        private static void DoEatApple()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du isst einen Apfel");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("10 LP hinzugefügt");
            Console.ResetColor();

            System.Threading.Thread.Sleep(5000);

            if (Data.characterData.HealthPoints > 90)
                Data.characterData.HealthPoints = 100;
            else
                Data.characterData.HealthPoints += 10;

            Data.WriteToConfigData(Data.characterData);

            DoEat();
        }

        private static void DoEatBanana()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du isst eine Banane");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("5 LP hinzugefügt");
            Console.ResetColor();

            System.Threading.Thread.Sleep(5000);

            if (Data.characterData.HealthPoints > 95)
                Data.characterData.HealthPoints = 100;
            else
                Data.characterData.HealthPoints += 5;

            Data.WriteToConfigData(Data.characterData);

            DoEat();
        }

        private static void DoEatChoclat()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du isst ein Stück Schokolade");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("5 LP abgezogen");
            Console.ResetColor();

            System.Threading.Thread.Sleep(5000);

            if (Data.characterData.HealthPoints < 5)
                Data.characterData.HealthPoints = 0;
            else
                Data.characterData.HealthPoints -= 5;

            Data.WriteToConfigData(Data.characterData);

            DoEat();
        }

        private static void DoEatPizza()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du isst ein Stück Pizza");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("10 LP abgezogen");
            Console.ResetColor();

            System.Threading.Thread.Sleep(5000);

            if (Data.characterData.HealthPoints < 10)
                Data.characterData.HealthPoints = 0;
            else
                Data.characterData.HealthPoints -= 10;

            Data.WriteToConfigData(Data.characterData);

            DoEat();
        }
    }
}