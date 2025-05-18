using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Game
{
    internal class Work
    {
        public static void DoMenu()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Willkommen in der Bäckerei. Du kannst Folgende Dinge Tuhen:");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Teig machen || Teigruhe || backen");
            Console.ResetColor();

            GetInput();
        }

        private static void GetInput()
        {
            string input = "";
            input = Console.ReadLine();

            while (true)
            {
                if (input == "Teig machen")
                    DoMakeDough();

                else if (input == "Weizenbrot")
                    DoMakeDoughWeathBread();

                else if (input == "Sauerteigbrot")
                    DoMakeDoughSourdoughBread();

                else if (input == "Teigruhe")
                    DoDoughReset();

                else if (input == "backen")
                    DoBaking();
                
                else
                    GetInput();
                   
            }
        }

        private static void DoMakeDough()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Was für einen Brotteig möchtest du herstellen?");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Weizenbrot || Sauerteigbrot");
            Console.ResetColor();

            GetInput();
        }

        private static void DoMakeDoughWeathBread()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du stellst aus Weizenmehl, Wasser, Salz und Hefe ein Brotteig für ein Weizenbrot her!");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Schreibe");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(" Teigruhe ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("um den Teig zur Gare zu stellen!");
            Console.ResetColor();

            GetInput();
        }

        private static void DoMakeDoughSourdoughBread()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du stellst aus Roggenmehl, Sauerteig, Wasser und Salz ein Sauerteigbrot-Teig her!");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Schreibe");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(" Teigruhe ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("um den Teig zur Gare zu stellen!");
            Console.ResetColor();

            GetInput();    
        }

        private static void DoDoughReset()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du stellst den Teig zur Teigruhe in den Kühlschrank. In wenigen Stunden ist der Teig bereit zum backen");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Schreibe");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(" backen ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("um die Teigline zu backen!");
            Console.ResetColor();

            GetInput();
        }

        private static void DoBaking()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du kannst den Teigling nun backen und hast dann ein super lackeres Brot");
            

            if (Data.characterData.HealthPoints < 20)
                Data.characterData.HealthPoints = 0;
            else
                Data.characterData.HealthPoints -= 20;

            
            Console.WriteLine("Du hast 20 LP durch das arbeiten verloren");

            System.Threading.Thread.Sleep(5000);

            Console.ResetColor();

            Data.WriteToConfigData(Data.characterData);

            Program.DoMenu();
        }
    }

    
}
