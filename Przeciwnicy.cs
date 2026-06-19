using gra;
using System;
using System.Collections.Generic;
using System.Text;

namespace GRA
{
    internal class Przeciwnicy
    {
        //=====================================================Przeciwnicy====================================
        internal static void WilkiA()
        {
            Console.Clear();
            Console.WriteLine("Czekasz i czekasz asz nagle słyszysz wycie watachy wilków które pędzo do ciebie.");
            Console.ReadKey();

            Przeciwnik wilki = new Przeciwnik("Watacha wilków", 80, 40);
            SystemWalki.RozpocznijWalke(wilki);

            if (Program.wybranyBohater.HP > 0)
            {
                Poziom1.Start();
            }
        }
        internal static void AbominacjaA()
        {
            Console.Clear();
            Console.WriteLine("Nieopodal spotykasz postać myśląc że to strażnik zbliżasz się do niego i widzisz że to nie człowiek a przerośniety ork z ludzki rysami twarzy tym czym było wcześniej.");
            Console.ReadKey();

            Przeciwnik abonimacja = new Przeciwnik("Abonimacja", 140, 55);
            SystemWalki.RozpocznijWalke(abonimacja);
            if (Program.wybranyBohater != null && Program.wybranyBohater.HP > 0)
            {
                Poziom1.kluczB = true;
            }

        }
        internal static void KaplanA()
        {
            Console.Clear();
            Console.WriteLine("Po tym co widziałęś spotykasz kapłana który kleka nad płonocym krzyżem na którym spalał się dziewczyna.");
            Console.ReadKey();

            Przeciwnik kaplan = new Przeciwnik("Diakon", 120, 90);
            SystemWalki.RozpocznijWalke(kaplan);

            if (Program.wybranyBohater.HP > 0)
            {
                Poziom1.lewoA();
            }
        }
        internal static void WladcaMuch()
        {
            Console.Clear();
            Console.WriteLine("Wyczuwasz zapach zgnilizny i rój much który otacza przestrzeń wokół ciebie. Przed tobą staje Humanoidalna istota pokryta pokładami ciał zgniły szczątków zmieszanych trópów połączonych ścignammi ich porywanymi mięśniami i potrzaskanych istot tworzyły ludzką hybryde ożytą by cie zabić.");
            Console.ReadKey();

            Przeciwnik wladcamuch = new Przeciwnik("WladcaMuch", 430, 120);
            SystemWalki.RozpocznijWalke(wladcamuch);
            if (Program.wybranyBohater.HP > 0)
            {
                Poziom1.KoniecB();
            }



        }
    }
}
