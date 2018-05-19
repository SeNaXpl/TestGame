using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.InterfaceComponents
{
    public static class MainMenu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("1. Nowa gra");
            Console.WriteLine("2. Wczytaj gre");
            Console.WriteLine("3. Opcje");
            Console.WriteLine("4. Wyjdz");
        }

        public static void NewGame()
        {
            Console.WriteLine("\nWybrano nowa gra");
            //Tworzenie postaci
        }

        public static void LoadGame()
        {
            Console.WriteLine("\nWybrano wczytaj gre");
            //Wybór save
        }

        public static void Settings()
        {
            Console.WriteLine("\nWybrano opcje");
            //Wyświetl opcje
        }
    }
}
