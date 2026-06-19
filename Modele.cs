namespace gra
{
    public class postac
    {
        public int HP { get; set; }
        public int Sila { get; set; }
        public int Mana { get; set; }
        public string Rodzaj { get; set; }

        public postac(int hp, int sila, int mana, string rodzaj)
        {
            HP = hp;
            Sila = sila;
            Mana = mana;
            Rodzaj = rodzaj;
        }
    }
    public class Przeciwnik
    {
        public string Nazwa { get; set; }
        public int HP { get; set; }
        public int Sila { get; set; }

        public Przeciwnik(string nazwa, int hp, int sila)
        {
            Nazwa = nazwa;
            HP = hp;
            Sila = sila;
        }
    }
}