namespace _3_Class_EnCapsulatin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Personel ali = new Personel();
            //ali.Ad = "Ali";
            //ali.Soyad = "Yilmaz";
            //string donendeger = ali.SetTcNo("a1234567891");
            //Console.WriteLine(donendeger);
            //Personel ayse = new Personel()
            //{
            //    Ad = "Ayse",
            //    Soyad = "Kaya"

            //};

            //Personel2 fatma = new Personel2();
            //fatma.TcNo = "12345678901";
            //Console.WriteLine(fatma.TcNo);


            Insan ali = new Insan("ali","yilmaz");

            //Class icerisinden ulasilabilen set metoduna atama yapilamaz
            // Burasi hata verecektir.
            //ali.Kilosu = 50;
            try
            {
                ali.HarclikAl(50);
                Console.WriteLine(ali.GetPara("Arkadasi"));
                Console.WriteLine(ali.GetPara("Baba"));
            }
            catch (Exception ex)
            {
                global::System.Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine("Alinin biriktirdigi para :"+ali.BiriktirdigiPara);
            Console.WriteLine("Hello, World!");
        }
    }
}