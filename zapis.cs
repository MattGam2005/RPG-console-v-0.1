using gra;
using System;
using System.IO;
using System.Text.Json;

namespace GRA
{
    public class StanGry
    {
        public string? Bezimienny { get; set; }
        public int HP { get; set; }
        public int Sila { get; set; }
        public int Mana { get; set; }
        public string? Rodzaj { get; set; }
        public bool KluczA { get; set; }
        public bool KluczB { get; set; }
    }

    internal static class zapis
    {
        public static void zapisywanie()
        {
            var aktualnystangry = new StanGry
            {
                Bezimienny = Program.bezimienny ?? "Bezimienny",
                KluczA = Poziom1.kluczA,
                KluczB = Poziom1.kluczB
            };

            string jsonString = JsonSerializer.Serialize(aktualnystangry);
            File.WriteAllText("save.json", jsonString);
            Console.WriteLine("Zapisano stan gry.");
        }

        public static bool Wczytaj()
        {
            const string file = "save.json";
            if (!File.Exists(file))
            {
                return false;
            }

            try
            {
                string jsonString = File.ReadAllText(file);
                var stan = JsonSerializer.Deserialize<StanGry>(jsonString);
                if (stan == null) return false;

                Program.bezimienny = stan.Bezimienny;
                Poziom1.kluczA = stan.KluczA;
                Poziom1.kluczB = stan.KluczB;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}