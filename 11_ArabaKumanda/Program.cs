namespace _11_ArabaKumanda
{
    internal class Program
    {

        public delegate void EventHandler();
        public delegate void EventTusaBasildi(string kod);
        static void Main(string[] args)
        {

            //Kumanda Acma Tusuna basilca arabanin kapilari acilsin.
            // Eger Baska bir kumanda tarafindan basildi ise işlem yapmasin.
            // Yani birden cok kumanda olabilir. birden cok anahtar tusa basma durumu olacak.
            // Arac sadece birisine tepki verecek

            //1. Faz : Anahtar tusuna basilir ise arabanin kapilari acma eymeli gerceklestirilir.

            Araba araba = new Araba("bmw123");
            Kumanda kumanda = new Kumanda("bmw123");
            Kumanda sahteKumanda = new Kumanda("TofasSerce");
            kumanda.AcmaTusunaBasildi += araba.SinyalAl;
            sahteKumanda.AcmaTusunaBasildi += araba.SinyalAl;
            sahteKumanda.TusaBas();
            kumanda.TusaBas();


            Console.WriteLine("Hello, World!");
        }
    }
}