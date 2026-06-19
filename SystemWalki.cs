using gra;
using System;


namespace GRA
{
    internal static class SystemWalki
    {
        private static Random rand = new Random();
        //====================================================walka======================================================

        public static void RozpocznijWalke(Przeciwnik wrog)
        {
            Console.Clear();

            if (Program.wybranyBohater == null)
            {
                Console.Clear();

                Console.WriteLine("Nie wybrano postaci. Wybierz postać najpierw.");
                Console.ReadKey();
                WyborPostaci.MenuWyboru();
                return;
            }
            while (wrog.HP > 0 && Program.wybranyBohater.HP > 0)
            {
                Console.Clear();
                Console.WriteLine($"                     {wrog.Nazwa} | HP: {wrog.HP}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("=========================================================================");
                Console.WriteLine($"=  {Program.bezimienny} | HP: {Program.wybranyBohater.HP} | Mana:{Program.wybranyBohater.Mana} =");
                Console.WriteLine("=========================================================================");
                Console.WriteLine("1. Atakuj");
                Console.WriteLine("2. Wykorzytaj mane");
                Console.WriteLine("3. Spróbuj uciec");
                Console.Write("Twój ruch: ");

                string akcja = Console.ReadLine();


                if (akcja == "1")
                {
                    int minAtakBohatera = Program.wybranyBohater.Sila / 3;
                    int maxAtakBohatera = Program.wybranyBohater.Sila;
                    int obrazeniaBohatera = rand.Next(minAtakBohatera, maxAtakBohatera + 1);

                    wrog.HP -= obrazeniaBohatera;
                    Console.WriteLine($"Zadałeś {obrazeniaBohatera} pkt OBR");

                    if (wrog.HP <= 0)
                    {
                        Console.WriteLine($"Pokonałeś: {wrog.Nazwa}");
                        Console.ReadKey();
                        return;
                    }

                    int obrazeniaWroga = rand.Next(wrog.Sila / 2, wrog.Sila + 1);
                    Program.wybranyBohater.HP -= obrazeniaWroga;
                    Console.WriteLine($"Atak zadaje ci {obrazeniaWroga} pkt");

                    if (Program.wybranyBohater.HP <= 0)
                    {
                        Console.WriteLine("Koniec GRY");
                        Console.ReadKey();
                        return;
                    }
                }
                else if (akcja == "2")
                {
                    //================================================Rycerz===========================================
                    if (Program.wybranyBohater.Rodzaj == "Rycerz")
                    {
                        Console.WriteLine("Brak czarów dla Rycerza.");
                        Console.ReadKey();
                        continue;
                    }
                    if (Program.wybranyBohater.Rodzaj == "Najemnik")
                    {
                        Console.WriteLine("1. Qui vivra verra |-400 pkt OBR| 30 pkt Many| 30% sukcesu |");
                        Console.WriteLine("2. Cebulowy okrąg |+10  pkt HP|-5 pkt Many|");
                        Console.WriteLine("3. Wycofaj się");
                        Console.WriteLine("Rzuć czar: ");
                        string wybor = Console.ReadLine();
                        switch (wybor)
                        {

                            case "1":
                                if (Program.wybranyBohater.Mana >= 40)
                                {
                                    Program.wybranyBohater.Mana -= 40;
                                    if (rand.Next(1, 101) <= 40)
                                    {
                                        wrog.HP -= 200;
                                        Console.WriteLine("Rzucone kości pozbawiły wroga nadzieji");
                                    }
                                }
                                else if (Program.wybranyBohater.Mana < 40)
                                {
                                    Console.WriteLine("Twoje kości rzucone nic nie dały");
                                }
                                else
                                {
                                    Console.WriteLine("Masz za mało many!");
                                }
                                break;
                            case "2":
                                if (Program.wybranyBohater.Mana >= 25)
                                {
                                    Program.wybranyBohater.Mana -= 25;
                                    Program.wybranyBohater.HP += 30;
                                    Console.WriteLine("Twoja Odkupiona dusza odzyskuje 30 pkt HP");
                                }
                                else
                                {
                                    Console.WriteLine("Masz za mało many!");
                                }
                                break;
                            case "3":
                                continue;

                            default:
                                Console.WriteLine("Błąd");
                                Console.ReadKey();
                                break;
                        }
                    }
                    //==============================================Barbaczyńca==========================================
                    if (Program.wybranyBohater.Rodzaj == "Barbaczyńca")
                    {
                        Console.WriteLine("1.Farlig er den, som intet har at miste |+40 pkt HP| -12pkt Many| 60% sukcesu |");
                        Console.WriteLine("2. Sulten ulv jager bedst |+10 pkt HP|-6 pkt Many|");
                        Console.WriteLine("3. Wycofaj się");
                        Console.WriteLine("Rzuć czar: ");
                        string wybor = Console.ReadLine();
                        switch (wybor)
                        {
                            case "1":
                                if (Program.wybranyBohater.Mana >= 12)
                                {
                                    Program.wybranyBohater.Mana -= 12;
                                    if (rand.Next(1, 101) <= 60)
                                    {
                                        Program.wybranyBohater.HP += 40;
                                        Console.WriteLine("Twój wewnętrzny wilk odzyskuje 40 pkt HP!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Zaklęcie się nie powiodło!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Masz za mało many!");
                                }
                                break;

                            case "2":
                                if (Program.wybranyBohater.Mana >= 6)
                                {
                                    Program.wybranyBohater.Mana -= 6;
                                    Program.wybranyBohater.HP += 10;
                                    Console.WriteLine("Twoja głodna dusza odzyskuje 10 pkt HP!");
                                }
                                else
                                {
                                    Console.WriteLine("Masz za mało many!");
                                }
                                break;
                            case "3":
                                break;
                            default:
                                Console.WriteLine("Błąd wyboru.");
                                Console.ReadKey();

                                break;
                        }
                    }
                }


                //====================================================MAG=================================================
                if (Program.wybranyBohater.Rodzaj == "Mag")
                {
                    Console.WriteLine("1. Piekielny żar |-60 pkt OBR|-22 pkt Many|");
                    Console.WriteLine("2. Alea iacta est |-200 pkt OBR| 40 pkt Many| 40% sukcesu |");
                    Console.WriteLine("3. Odkupienie |+30 pkt HP|-25 pkt Many|");
                    Console.WriteLine("4. Wycofaj się");
                    Console.WriteLine("Rzuć czar: ");
                    string wyborA = Console.ReadLine();
                    switch (wyborA)
                    {
                        case "1":
                            if (Program.wybranyBohater.Mana >= 15)
                            {
                                Program.wybranyBohater.Mana -= 15;
                                wrog.HP -= 60;
                                Console.WriteLine("Przeciwnik zajął się piekielnym ogniem! Zadałeś 60 pkt OBR.");
                            }
                            else
                            {
                                Console.WriteLine("Masz za mało many!");
                                Console.ReadKey();
                                continue;
                            }
                            break;

                        case "2":
                            if (Program.wybranyBohater.Mana >= 40)
                            {
                                Program.wybranyBohater.Mana -= 40;
                                if (rand.Next(1, 101) <= 40)
                                {
                                    wrog.HP -= 200;
                                    Console.WriteLine("Rzucone kości pozbawiły wroga nadzieji");
                                }
                            }
                            else if (Program.wybranyBohater.Mana < 40)
                            {
                                Console.WriteLine("Twoje kości rzucone nic nie dały");
                            }
                            else
                            {
                                Console.WriteLine("Masz za mało many!");
                            }
                            break;
                        case "3":
                            if (Program.wybranyBohater.Mana >= 25)
                            {
                                Program.wybranyBohater.Mana -= 25;
                                Program.wybranyBohater.HP += 30;
                                Console.WriteLine("Twoja Odkupiona dusza odzyskuje 30 pkt HP");
                            }
                            else
                            {
                                Console.WriteLine("Masz za mało many!");
                            }
                            break;
                        case "4":
                            continue;
                            break;
                        default:
                            Console.WriteLine("Błąd");
                            Console.ReadKey();
                            break;
                    }
                    if (wrog.HP <= 0)
                    {
                        Console.WriteLine($"Pokonałeś: {wrog.Nazwa}");
                        Console.ReadKey();
                        Poziom1.Start();
                        return;
                    }



                }
                else if (akcja == "3")
                {
                    Console.WriteLine("Udoło Ci się.");
                    Console.ReadKey();
                    return;
                }
                if (wrog.HP <= 0)
                {
                    Console.WriteLine($"Pokonałeś: {wrog.Nazwa}");
                    Console.ReadKey();
                    return;
                }

                Console.ReadKey();
            }
        }
    }
}
