using GRA;
using System;
using System.Collections;
using static gra.Program;

namespace gra
{
    internal class Program
    {
        private static Random rand = new Random();

        public static postac wybrane;
        public static postac wybranyBohater;
        public static string bezimienny;
        static void Main(string[] args)
        {
            MenuGlowne();
        }
        public static void MenuGlowne()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("=           Jądro Ciemności         =");
                Console.WriteLine("=          Wersja tekstowa         =");
                Console.WriteLine("=               Demo               =");
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1. Zacznij gre:");
                Console.WriteLine("2. Wczytaj gre");
                Console.WriteLine("3. Wyjdź z gry:");
                Console.Write("Wpisz: ");
                string wybor = Console.ReadLine();


                switch (wybor)
                {
                    case "1":
                        WyborPostaci.StartGry();
                        break;
                case "2":
                        if (zapis.Wczytaj())
                        {
                            Poziom1.korytarzA();
                        }
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Błąd");
                        Console.ReadLine();
                        break;
                }
            }
        }
    public static void Reset()
        {
            Poziom1.kluczA = false;
            Poziom1.kluczB = false;
            MenuGlowne();

        }
}
}