namespace _16_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ali = new Ogrenci();
            ali.AdSoyad = "Ali Yilmaz";
            ali.TcNo = "1231313";


            //Ogrenci Sinifinin property'lerini bulmaya yarar
            Console.WriteLine("Ogrenci Sinifinin Property'leri");
            foreach (var item in ali.GetType().GetProperties())
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Ogrenici sinifinin Interface'i");

            Console.WriteLine(ali.GetType().GetInterface("IOgrenci").ToString());

            // Ogrenci Sinifinin inherit aldigi base Type verir
            Console.WriteLine(ali.GetType().BaseType.ToString());


            // Class icerisindeki metodlari getirmeye yarar.
            foreach(var item in  ali.GetType().GetMethods())
            {

                Console.WriteLine(item.Name);
                Console.WriteLine(item.ReturnType);
                Console.WriteLine(item.DeclaringType);
                //Console.WriteLine(item.Invoke(null,null));




            }

            Ogretmen ayse = new Ogretmen();

            Sinif z33 = new Sinif();
            z33.Ogretmen = ayse;

            z33.Ogrenciler.Add(ali);

            //Console.WriteLine("-------- Sinif class'i icin Property'leri ---------------");
            //foreach (var item in z33.GetType().GetProperties())
            //{
            //    Console.WriteLine(item.Name);

            //    foreach (var prop in item.GetType().GetProperties())
            //    {
            //        Console.WriteLine(prop.Name);
            //    }
            //    Console.WriteLine("---------------    ---------------");
            //}

            Console.WriteLine("Hello, World!");
        }
    }
}