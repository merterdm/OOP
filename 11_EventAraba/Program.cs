namespace _11_EventAraba
{

    public delegate void ArabaDelegate(int a, object sender);

    internal class Program
    {
        static void Main(string[] args)
        {
            //Hizlanan bir arac 120 km 'yi gecince polis söföre ceza kessin
            // 
            //Araba gaza basinca hizlansin

            Araba araba = new Araba("34 ABC 45",180);
            Polis polis = new Polis("Guven Kaya");
            Sofor sofor = new Sofor("Ali Yilmaz");
            araba.HareketEdiyorum += polis.HizKontrolEt;
            sofor.GazaBastim += araba.Calis;

            sofor.GazaBas();

            Console.ReadLine();
        }
    }
}