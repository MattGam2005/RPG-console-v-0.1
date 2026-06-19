using gra;
using System;


namespace GRA
{
    internal class WyborPostaci
    {
        public static void StartGry()
        {

            Console.Clear();
            Console.Write("Podaj swoje imie: ");
            Program.bezimienny = Console.ReadLine();
            MenuWyboru();


        }
        //=========================================================Wybieranie postaci====================================================
        public static void MenuWyboru()
        {
            Program.wybranyBohater = null;

            while (Program.wybranyBohater == null)
            {
                Console.Clear();

                Console.WriteLine("Wybierz postać:");
                Console.WriteLine();


                Console.WriteLine("1. Rycerz");
                var pRycerz = new postac(160, 55, 10, "Rycerz");
                Console.WriteLine($"HP: {pRycerz.HP} pkt, Siła: {pRycerz.Sila} pkt, Mana: {pRycerz.Mana} pkt");

                Console.WriteLine("2. Mag");
                var pMag = new postac(90, 20, 185, "Mag");
                Console.WriteLine($"HP: {pMag.HP} pkt, Siła: {pMag.Sila} pkt, Mana: {pMag.Mana} pkt");

                Console.WriteLine("3. Barbaczyńca");
                var pBarbacz = new postac(95, 70, 80, "Barbaczyńca");
                Console.WriteLine($"HP: {pBarbacz.HP} pkt, Siła: {pBarbacz.Sila} pkt, Mana: {pBarbacz.Mana} pkt");

                Console.WriteLine("4. Najemnik");
                var pNajemnik = new postac(100, 50, 65, "Najemnik");
                Console.WriteLine($"HP: {pNajemnik.HP} pkt, Siła: {pNajemnik.Sila} pkt, Mana: {pNajemnik.Mana} pkt");



                Console.Write("Wpisz: ");
                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        Program.wybranyBohater = pRycerz;
                        Rycerz();
                        break;
                    case "2":
                        Program.wybranyBohater = pMag;
                        Mag();
                        break;
                    case "3":
                        Program.wybranyBohater = pBarbacz;
                        Barbaczyńca();
                        break;
                    case "4":
                        Program.wybranyBohater = pNajemnik;
                        Najemnik();
                        break;
                    default:
                        Console.WriteLine("Błąd");
                        Console.ReadKey();
                        break;
                }
            }
        }


        //=========================================================================Opis bohatera====================================================================
        private static void Rycerz()
        {
            Console.Clear();
            Console.WriteLine("Rycerz jesteś szlachetnym palladynem w czasach chaosu i głodu którą prześladuje zmarnonią ziemie upadłych narodów, królestw i cnót.Od urodzenia byłęś przygotowany do swojej roli gdzie wmawiano byś chronił słabych i tych którzy cie karmią.Ale czym wiecej wojen i krwi przelanej na twój widok straciłeś ideały widząc że twoje czyny tylko zmacniają lordów i majetnych panów.Kiedy straciłęs nadziej od nalazłeś nowy cel jakim był Le'Alighiler który spośród tysięcy towarzyszy i dziesiątek tysięcy wrogów ścietych, jest jedynym który , sprawił że zaponimasz o swojej przeszłośći i sumieniu. Mimo że był z rodziny chłopskiej udzielało się wnim coś nieziemskiego swej posturze. Dzieki swojego doświadzczenia i pokory szybko awansowałeś co zostało zauwarzone przez Le'Alighilera.Jego mała drużyna najemna stała się nową siłą na zachodzie która na zachodzie Europy stawała się wikeszym zagrożeniem dla władców. Obawie że Le'Alighiler długo letni najemnik przejmie kontrole nad państwem wypowiedzieli mu wojne po donosach o zbrodniach na północy których dokonał. Bitwe przegrał a Le'Alighiler został pojmany i wsadzono go do antycznych ruin które przekształcono w wiezienie jądra ciemności. Tobie się udało uciec z bitwy i samotnie zaczołeś szukać swojego mentora po króleswie aż dotarłęś do wiezienia jądra ciemności.");

            Console.WriteLine("Zacznij gre: ");
            Console.ReadKey();
            Poziom1.Start();
        }

        private static void Mag()
        {
            Console.Clear();
            Console.WriteLine("Mag zostałeś porzucony po urodzeniu pod progi klasztoru. Od urodzenia twoją rodzinną był zakon i religia co wykrzatałci w tobie miłość rodzinną do zakonnu i religi. Jako młody pospulat poszłeś zaczołęś okres kanoniczny co pozwoliło ci na zaczecie nauki. Odkryłeś wielki talent do czytania i pojmowania wiedzy. Głebokim zainteresowaniem były pozwolone przez władze kościelne jako przywilej do nauki o okultiźmie i egzorcyzmach. Natchniony wiedzą zaczołeś pojmować i praktykować wiedze co pozwoliło Ci na osiągniecie po 8 latach wiedzy mistrzowskiej. ALe to miało też wieksze konsekwencje czym wiec wiedzy tym traciłeś poczucie jedności z człowieczeństwem oraz tym że szukanie wiedzy się skończyło gdy nagle podczas Ewokacji doznałeś wizji że odpowiedzią na wszystkie pytania jest Le'Alighiler który w wizjach w ozłacanych szatach w sowimch piórach wykońzczona ze złamanym na jego rence. Druga dłoń wskazywała ruiny antycznego miasta Haramb które przetworzono w wiezienie. Te wizje cię wybudziły jak huk piorunów siarczystych wiedząc że musisz poznać prawdę i nastpnego dnia spakowałęś się  i ruszyłeś do wiezienia jądra ciemności. ");

            Console.WriteLine("Zacznij gre: ");
            Console.ReadKey();
            Poziom1.Start();
        }

        private static void Barbaczyńca()
        {
            Console.Clear();
            Console.WriteLine("Barbaczyńca od urodzenia byłeś wychowywany w dzikich ludach północy które od pokoleń które plądrowało i zniewalanie narodów. Od jakieś czasu coś się zmieniło pod napływem handlu, nauki i religi zmieniał twój kraj. Twoja rodzina należaca do wysoko podstawionych jarlów widząc że tracą wpływy i przywileje wczeli rebelie we własnym kraju. Wraz z rodziną i wojami stoczyłeś wiele kampani wojennych stoczonych bitew których nabrałeś siły jak i blizn doszło do ostatecznej bitwy w dolinie trzech rzek gdzie stoczyłeś bitwe z wojskami wysłanymi z zachodu którą dowodził Le'Alighiler. Bitwa która została stoczona poniosła się jako kleska  w której jako jedyny przeżyłęś rzeź którą później najemnicy Le'Alighilera dobijali i podpalali rannych wojów na własnych oczach. Po przeżytej gehemie przeklnołeś Le'Alighilera i obiecałeś na swój honor i dusze że zgładzisz Le'Alighilera za wszelką cene. Wiedząc że nic nie zrobisz w kraju pojołęś nauk od oddanego druida by cie przygotował do swojej misji oraz by cie wyleczył. Po 2 latach rehabilitacji i nauk wyruszyłeś na zachód by znaleść i zemścić na nim nie ważne gdzie się znajduje i tak dotarłeś do wiezienia jądra ciemności.");

            Console.WriteLine("Zacznij gre: ");
            Console.ReadKey();
            Poziom1.Start();
        }

        private static void Najemnik()
        {
            Console.Clear();
            Console.WriteLine("Najemnik od dziecka byłeś duszą ciekawską interesowałeś jak działa świat ale twoja rodzina która zajmowała się handlem podróźowałeś w wszystkie strony kontynentu. Brak domu i czeste podróżowanie na szlaku przygotowowywały cię do roli handlarza jak nauka alfabetu i liczenia do momentu gdy twoja rodzina została napadnieta przez leśne bandy dezerterów które wybiły Ci rodzine. Myślałeś że zginiesz ale zjawili się grupa najemników na usługach korony która uratowali cię ale ten ratunek kosztował Cię tym że zostałeś najemnikiem w ich grupie na 10 lat. Wciągu tych lat nabrałeś doświadczenia w walce oraz tym że znałeś zaklecia uzdrawiające stawałęś się legendarnym łowcą nagród szukających nowych zleceń. Miedzy czasie zakochałeś się w ubogiej prostytucce której się zaciążyła z tobą. Wiedząc żę życie której wy żejecie nie pozwoli wam żyć normalnie więc zaczołeś szukać nowych zleceń które pozwolą CI się wzbogacić. I ten dzień nadszedł dostałęś zlecenie na Le'Alighilera którego dano wysokoą nagrode która pozwoli Ci na życie w dostatku. Zbierając informacje oraz sprzet i żegnją ukachaną wyruszyłeś w kierunku ruin nazwanych wiezieniem jądra ciemności.");

            Console.WriteLine("Zacznij gre: ");
            Console.ReadKey();
            Poziom1.Start();
        }

    }
}
