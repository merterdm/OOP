using System.Reflection.Metadata;
using System;

namespace _13_GenelTekrar
{
    public class SonucSeti
    {
        public double Carpma { get; set; }
        public double Bolme { get; set; }
        public double Cikarma { get; set; }
        public double Toplama{ get; set; }

        public SonucSeti(int a,int b)
        {
            Carpma = a * b;
            Bolme = a / b;
            Cikarma = a - b;
            Toplama = a + b;
        }

        public override string ToString()
        {
            return "Toplam:" + Toplama + " Carpim:" + Carpma + " Bolum:" + Bolme + " Cikarma:" + Cikarma;
        }
    }

    internal class Program
    {
        struct Kisi 
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Description { get; set; }


        }
        
        public interface Iinterface
        {
            void test();
        }

        class A
        {

        }

        struct Person : Iinterface
        {
            public void test()
            {
                throw new NotImplementedException();
            }
        }

         //Geri dönüş tipi olmayan ve int tipinden iki adet parametre alan metodlar için kullanılır.
        public delegate void MyDelegeHandler2(int a, int b);   
        public delegate int DortIslem2(int a, int b);   
        public delegate string MyDelegeHandler4();
        public delegate SonucSeti DortIslemDelegate(int a, int b);

        public void Toplama(int a, int b)
        {
            Console.WriteLine("Toplam:" +(a+b));
        }
        public static  int Carpma(int a, int b)
        {
            return a * b;
        }
        public static int Topla(int a, int b)
        {
            return a + b;
        }
        public static int Cikarma(int a, int b)
        {
            return a - b;
        }

        public static int Bolme(int a, int b)
        {
            return a / b;
        }
        public static SonucSeti DortIslem(int a, int b)
        {
            SonucSeti sonuc = new SonucSeti(a, b);
            return sonuc;
        }
        static void Main(string[] args)
        {

            #region Partial Class
            Kisi ali = new Kisi();
            #endregion



            #region Strcut ile Class Arasindaki Farklar
            // Struct (YApi): birbiriyle ilikili degiskenlerin bir isaim altinda toplanmasina verile isimdir.
            // Struct baska bir struct'a kalitim veremez. Baska bir class yada struct'tan kalim alamaz. 
            // Struct'lar ancak interface'lerden kalitim alabilirler.
            //Struct'lar Stack'te tutulu. 64Kb siniri vardir.





            #endregion


            #region Erisim Belirtecleri
            //public : Her taraftan ulasilabilir.
            // private : Sadece Class icerisinden ulasilabilir.
            // protected : Instance alindignda ulasilamaz. Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
            // Internal : Programin calistigi assembbly 
            // Protected Internal : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
            //                    Ayrıca tanımlamanın aynı proje içerisinde olma şartı yoktur. Protected'dan farkı budur.
            // Eğer erişim belirleyici belirtilmemişse, sınıflar internal’dır.
            #endregion


            #region Delegate 

            // Delegate
            //Delegeler, metodların adreslerini dolayısıyla metodların kendilerini tutabilen, işaret edebilen yapılardır.
            //NOT : Metodlar da bellekte oluşan ve bellek adresleri olan yapılardır.
            //Delegeler referans tipli yapılardır.Yani nesne oluşturulabilirler.
            //Şimdi bir delege yapısı nasıl olur bakalım.
            //[Erişim Belirleyicisi] delege[geri dönüş tipi][delege ismi](eğer varsa parametre)
            //Örnek olarak aşağıdaki delege yapısını inceleyiniz.


            //DortIslemDelegate islemDelegate = new DortIslemDelegate(DortIslem);
            //Console.WriteLine(islemDelegate.Invoke(8, 4));


            //DortIslem2 islem2 = new DortIslem2(Topla);
            //islem2 += Cikarma;
            //islem2+= Bolme;
            //islem2 += Carpma;

            //Console.WriteLine(islem2.Invoke(8, 4));

            //Geri dönüş tipi int olan ve int tipinden iki adet parametre alan metodlar için kullanılır.


            //Geri dönüş tipi string olan ve parametre almayan metodlar için kullanılır.
            #endregion


            #region Event
           //            (Event)Kavramı

            //Olaylar, nesne yönelimli programlama ortamlarında devamlı olarak kullanılırlar.Burada en çok bilinen örnek,
            //Button(düğme) sınıfına ait olan bir nesne için Click(tıklama) isimli eventdir.
            //Click eventinde fareyle button nesnesinin üzerine tıklandığında ortama bir olay fırlatılır.
            //Ayrıca, olaylar veritabanındakiTrigger(tetikleyici)‘lar gibi düşünülebilir.Olaylar program içinde gerekli
            //şartlar sağlandığında kendiliğinden gerçekleşirler. Çağırılmalarına gerek yoktur.Metodlardan bu noktada farklıdırlar.

            //Olaylar kullanılacağı zaman bunu gerçekleştirmek için temsilcilere başvurulur.
            //Olaylar temsilci türünden yaratılarak ortama fırlatılabilir.
            #endregion
            //SonucSeti sonuc =  DortIslem(5, 2);
            //Console.WriteLine(sonuc);
        }
    }
}