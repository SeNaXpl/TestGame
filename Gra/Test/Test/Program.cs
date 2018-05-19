using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.InterfaceComponents;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            char selection = '0';
            int selectionConverted = 0;

            while (selectionConverted!= 4)
            {
                MainMenu.DisplayMenu();
                selection = Console.ReadKey().KeyChar;

                if (int.TryParse(selection.ToString(), out selectionConverted))
                {
                    switch (selectionConverted)
                    {
                        case 1:
                            MainMenu.NewGame();
                            break;
                        case 2:
                            MainMenu.LoadGame();
                            break;
                        case 3:
                            MainMenu.Settings();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nWybrano zla wartosc!");
                    
                }

            }
        }
    }
}
