using gra;
using System;
using System.Collections.Generic;
using System.Text;

namespace GRA
{
    internal class Poziom1
    {
        //==============================================================Przed zamkiem========================================================
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("Znajdujesz się na przepolu ogromego wiezienia. Odór ruin do których się z bliżasz do wiezienia czujesz śmierć która zawłaszczyła ten budynek");
            Console.WriteLine("Co robisz");
            Console.WriteLine("1. Wejdź");
            Console.WriteLine("2. Czekaj");
            Console.WriteLine("3. Uciekaj");

            string wybor = Console.ReadLine();
            switch (wybor)
            {
                case "1":
                    korytarzA();
                    break;
                case "2":
                    int czekanie = 0;

                    czekanie++;
                    if (czekanie == 1)
                    {
                        Przeciwnicy.WilkiA();
                    }
                    else
                    {
                        Console.WriteLine("Nie ma wilków");
                        Console.ReadKey();
                        Start();
                    }
                    break;
                case "3":
                    KoniecA();
                    break;
                default:
                    Console.WriteLine("Błąd");
                    Console.ReadKey();
                    WyborPostaci.MenuWyboru();
                    break;
            }
        }

        //============================================================Wejście================================================================
        internal static void korytarzA()
        {
            Console.Clear();
            Console.WriteLine("Wchodzisz na korytarz. Czujesz wniej zimny chłód który wydobywał się wgłębi ale rozglodasz się i widzisz trzy wejścia od lewej i prawej oraz główne drzi na wprost korytarza.");
            Console.WriteLine();
            Console.WriteLine("Dzwi główne są zamkniete dwoma zamkami ");
            Console.WriteLine();
            Console.WriteLine("Co robisz");
            Console.WriteLine("1. Idź lewo");
            Console.WriteLine("2. Idź prawo");
            Console.WriteLine("3. Idź prosto");

            string wybor = Console.ReadLine();
            switch (wybor)
            {
                case "1":
                    lewoA();
                    break;
                case "2":
                    prawoA();
                    break;
                case "3":
                    dzwiA();
                    break;
                default:
                    Console.WriteLine("Błąd");
                    Console.ReadKey();
                    korytarzA();
                    break;
            }
        }
        //====================================================Wejście w prost======================================================
        private static void dzwiA()
        {
            Console.Clear();
            if (kluczA == true && kluczB == true)
            {
                Console.WriteLine("Otwierają się ...");
                Console.WriteLine("1. Idź dalej");
                Console.WriteLine("2. Uciekaj");


                string wybor = Console.ReadLine();
                switch (wybor)
                {
                    case "1":
                        ProstoA();
                        break;
                    case "2":
                        KoniecA();
                        break;

                    default:
                        Console.WriteLine("Błąd");
                        Console.ReadKey();
                        dzwiA();
                        break;
                }
            }

            else if (kluczA == true && kluczB == false)
            {
                Console.WriteLine("Brakuje ci drugiego klucza");
                Console.ReadKey();
                korytarzA();

            }
            else if (kluczA == false && kluczB == true)
            {

                Console.WriteLine("Brakuje ci pierwszego klucza");
                Console.ReadKey();
                korytarzA();
            }
            else
            {
                Console.WriteLine("Nie masz kluczy");
                Console.ReadKey();
                korytarzA();
            }
        }



        private static void ProstoA()
        {
            Console.Clear();

            Console.WriteLine("Wchodzisz na dziedzinie na gdzie poza mrokiem i strachem na potykasz przyrode gdzie na ściezce widzisz krzyże nabijanych martwych ludzi w różnych stanie rozkładu wzdłuż której idziesz i napotykasz na istote o dużych gabarytach.");
            Console.WriteLine();
            Console.WriteLine("Co robisz");
            Console.WriteLine("1. Walcz");
            Console.WriteLine("2. Uciekaj");

            string wybor = Console.ReadLine();
            switch (wybor)
            {
                case "1":
                    Przeciwnicy.WladcaMuch();
                    break;
                case "2":
                    KoniecA();
                    break;
                default:
                    Console.WriteLine("Błąd");
                    Console.ReadKey();
                    dzwiA();
                    break;
            }


        }

        //====================================================Wejście w w lewo======================================================
        public static bool kluczA = false;
        internal static void lewoA()
        {
            Console.Clear();
            if (!kluczA)
            {
                Console.WriteLine("Wchodzisz przez portal do któego okazuje się że wyczuwasz dym który wydobywa się wokół całej kaplicy gdzie stał podaplaony krzyż a przed nim modlący człowiek. Wiec podchodzisz i ...");
                Console.WriteLine("Co robisz");
                Console.WriteLine("1. Atakujesz");
                Console.WriteLine("2. Rozmawiasz");
                Console.WriteLine("3. Uciekasz");

                string wybor = Console.ReadLine();
                switch (wybor)
                {
                    case "1":
                        Przeciwnicy.KaplanA();
                        break;
                    case "2":
                        RozmowaA();
                        break;
                    case "3":
                        dzwiA();
                        break;
                    default:
                        Console.WriteLine("Błąd");
                        Console.ReadKey();
                        lewoA();
                        break;
                }

            }
            else
            {
                Console.Clear();

                Console.WriteLine("Wchodzisz do kaplicy. W powietrzu unika się zapach spalonego mięsa i kadzideł.");
                Console.WriteLine("Na kamiennej posadce leży martwe ciało oszalałego kapłana.");
                Console.WriteLine("Co robisz?");
                Console.WriteLine("1. Podejdź do ambony");
                Console.WriteLine("2. Wróć na korytarz");

                string wybor = Console.ReadLine();
                if (wybor == "1")
                {
                    ambona();
                }
                else
                {
                    korytarzA();
                }
            }
        }

        private static void RozmowaA()
        {
            Console.Clear();
            Console.WriteLine("- Co się dzieje ? |ty|");
            Console.WriteLine("Kapłan odwrócił się w kierunku twojej osoby. Jego sine usta otworzyły się.");
            Console.WriteLine("-Spełniam wole boga |kapłan|");
            Console.WriteLine("-Czego chcesz pobożny człowieku? |kapłan|");
            Console.WriteLine();
            Console.WriteLine("Co mówisz");
            Console.WriteLine("1. Atakujesz");
            Console.WriteLine("2. Pytasz co robi?");
            Console.WriteLine("3. zapytaj o klucz");

            string wybor = Console.ReadLine();
            switch (wybor)
            {

                case "1":
                    Przeciwnicy.KaplanA();
                    break;
                case "2":
                    Console.WriteLine("- Boże zlecenie mój niedowiarku spełniam. Tamta dziewica zostaje przekazywana jako jamużna dla naszego pana. |kapłan|");
                    RozmowaA();
                    break;
                case "3":
                    Console.WriteLine("- Klucz się pytasz mój niedowiarku ona leży w mej anbnie mój drogi |kapłan|");
                    ambona();
                    break;
                default:
                    Console.WriteLine("Błąd");
                    Console.ReadKey();
                    RozmowaA();
                    break;
            }
        }
        private static void ambona()
        {
            Console.Clear();

            Console.WriteLine("Widzisz przed sobą klucz do bramy");
            Console.WriteLine("Zdobywasz klucz");
            kluczA = true;
            Console.ReadKey();
            korytarzA();
        }
        //====================================================Wejście w w prawo=====================================================
        public static bool kluczB = false;
        private static void prawoA()
        {
            Console.Clear();
            Console.WriteLine("Wchodzisz wgłąb otwartej przestrzeni wokół widać po przewracane meble i różne mienie zakurzone od miesiecy. Nie opodal zauważasz nie zgrabną postać jakby przerośnietą i nieludzko wysoką. Zbliżasz się i widzisz że to nie człowiek nim jest lecz coś co było człowiekiem podchodzi do ciebie z rykiem tysiecy wrzasków bólu i śmierci. Przed tobą staje abonimacja");
            Console.ReadKey();

            Przeciwnicy.AbominacjaA();

            if (Program.wybranyBohater.HP > 0 && kluczB == true)
            {
                Console.WriteLine("Po wyczyszczeniu przedsionka znalazłeś stare łóżko");
                Console.WriteLine("Chcesz zapisać aktualny stan gry? (t/n)");
                string odp = Console.ReadLine();

                if (!string.IsNullOrEmpty(odp) && (odp.StartsWith("t", StringComparison.OrdinalIgnoreCase)
                    || odp.StartsWith("y", StringComparison.OrdinalIgnoreCase)))
                {
                    zapis.zapisywanie();
                }
                else
                {
                    Console.WriteLine("Powrót do korytarza");
                    Console.ReadKey();
                    korytarzA();
                }
            }
        }
        //==================================================================KOniec==========================
        public static void KoniecA()
        {
            Console.Clear();
            Console.WriteLine("Uciekasz cenisz życie niż ryzyko. Czasami instykt głodu i strachu jest silniejszy od naszej logigi.)");
            Console.ReadKey();
            WyborPostaci.MenuWyboru();
        }

        public static void KoniecB()
        {
            Console.Clear();
            Console.WriteLine("Gratulacje przeszłeś poziom 1 poziom wiezienia jądra ciemności.)");
            Console.WriteLine("To wszystko to narazie jest Demo.)");
            Console.ReadKey();
            Program.Reset();
        }
    }
}
