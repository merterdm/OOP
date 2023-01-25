namespace _10_Delegate
{
    internal class Program
    {

        /*
         
         Delegate: Metodlari temsil eden yapilardir


         Örnek tanimlama 
        <Erisim_Belirteci> delegate <Temsil_Edilen_Metodun_Geri_Donus_Tipi> <DelegeAdi>(<parametreler>)
          public    delegate            int  hesaplayici(int a,int b)


         */


        public  delegate void hesaplayici(int a, int b);
        static void Main(string[] args)
        {
            hesaplayici test = Topla ;
            test += deneme;

            test += Cikar;
            test+= Carp;
            test+= Bolme;
            test -= deneme;
            ExternalMetodClass externalMetod = new ExternalMetodClass();
            test += externalMetod.TestMetod;
            
            test.Invoke(10, 5);


            Console.WriteLine("Hello, World!");
        }

        public static void deneme(int a, int b)
        {
            Console.WriteLine("deneme");
        }

        public static void Topla(int a, int b)
        {
            Console.WriteLine("Toplam:"+(a + b));
        }

        public static void Cikar(int a, int b) => Console.WriteLine("Fark:"+(a-b));

        public static void Carp(int a, int b)
        {
            Console.WriteLine("Carpim :" +(a * b));
        }
        public static void Bolme(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine(0);
            }
            Console.WriteLine("Bolme:"+(a / b));
        }

    }
}