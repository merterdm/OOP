using _9_Polimorfizm.AlanHesabi;
using _9_Polimorfizm.Emlak;
using _9_Polimorfizm.Personeller;

namespace _9_Polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Alan Hesabi
            //Kare kare = new Kare();
            //kare.Kenar = 5;
            //Dikdortgen dikdortgen = new Dikdortgen();
            //dikdortgen.KisaKenar = 5;
            //dikdortgen.UzunKenar = 15;



            //Console.WriteLine("Dikdortgen Alani:" + dikdortgen.Alan());

            //Console.WriteLine("Kare Alani:" + kare.Alan());
            //Daire daire = new Daire();
            //daire.YariCap = 5;
            //Console.WriteLine("Daire Alani:" + daire.Alan()); 
            #endregion

            #region Maas Hesabi

            Sekreter ayse = new Sekreter()
            {
                AdSoyad = "Ayse",
                CocukSayisi = 2,
                EgitimDurumu = EgitimDurumu.Lise

            };

            Yazilimci ali = new Yazilimci()
            {
                AdSoyad = "Ali",
                CocukSayisi = 2,
                EgitimDurumu = EgitimDurumu.YuksekLisans,
                Seviye = Seviye.Orta

            };

            ItMuduru fatma = new ItMuduru()
            {
                AdSoyad = "Fatma",
                CocukSayisi = 2,
                EgitimDurumu = EgitimDurumu.Doktora,
                Performansi = Persormans.Iyi,
                Seviye = Seviye.Usta
            };


            Console.WriteLine("Sekreter  Maasi" + ayse.MaasHesapla());
            Console.WriteLine("Orta Yazilimci  Maasi" + ali.MaasHesapla());
            Console.WriteLine("Orta Yazilimci  Maasi" + fatma.MaasHesapla());





            #endregion


            #region Emlak Kira Hesaplama


            KonutDaire daire = new KonutDaire(Kimden.Emlakcidan,90,3)
            {
                BinaYasi = 5,
                EmlakTipi = EmlakTipi.Daire,
                EsyaliMi = true,
                SiteIcerisindeMi = true,
                OdaSayisi = 3
            };
            
            double kira = daire.KiraHesapla();
            Console.WriteLine("Olusan Kira:"+kira);

            Residance res = new Residance(Kimden.Emlakcidan,90,5,2000)
            {
                BinaYasi = 5,
                EmlakTipi = EmlakTipi.Daire,
                EsyaliMi = true,
                SiteIcerisindeMi = true,
                OdaSayisi = 3,
                
            };

            Console.WriteLine("Residance icin olusan Kira:"+res.KiraHesapla());



            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}