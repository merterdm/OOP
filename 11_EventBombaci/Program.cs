namespace _11_EventBombaci
{

    public delegate void Eventtip();
    internal class Program
    {
        static void Main(string[] args)
        {

            //Telefon Gorusmesinde "Aliveli4950" kelimesi gecerse bomba patlasin

            Telefon telefon = new Telefon();
            Bomba bomba = new Bomba();
            telefon.KelimeKullanildi += bomba.Patla;

            telefon.Gorusme();
            Console.WriteLine("Hello, World!");
        }
    }
}