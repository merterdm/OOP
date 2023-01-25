using System;
using _7_InterfaceLab.FaturaKesim;
using _7_InterfaceLab.FirinOtomasyon;
using _7_InterfaceLab.Guvenlik;

namespace _7_InterfaceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region KaraFirin
            //Usta aliUsta = new Usta();
            // aliUsta.Isim = "Ali Yilmaz";

            // Urun un = new Urun();
            // un.Isim = "Beyaz Un";
            // un.Birim = Birim.Gram;
            // un.Mitar = 3000;
            // un.Fiyat = 1;

            //Urun tuz = new Urun();
            // tuz.Isim = "Kaya Tuzu";
            // tuz.Mitar = 200;
            // tuz.Birim = Birim.Gram;
            // tuz.Fiyat= 1;

            // Urun su = new Urun();
            // su.Isim = "Musluk Suyu";
            // su.Mitar= 200;
            // su.Fiyat = 1;
            // su.Birim = Birim.Mlitre;

            // List<Urun> urunler = new List<Urun>();
            // urunler.Add(un);
            // urunler.Add(su);
            // urunler.Add(tuz);

            // YogurmaMakinasi yogurmaMakinasi = new YogurmaMakinasi();
            // yogurmaMakinasi.MakinaAdi = "Bosh";

            // IYogur yogurucu = new Usta();
            // IYogur makinayogurucu = new YogurmaMakinasi();
            // Firin karafirin = new Firin();

            // //karafirin.EkmekPisir(urunler, aliUsta);
            // //karafirin.EkmekPisir(urunler, yogurmaMakinasi);

            // karafirin.EkmekPisir(urunler,aliUsta); 
            #endregion

            #region Guvenlik
            //List<GirisKarti> girisKarlari = new List<GirisKarti>();

            //GuvenlikGorevlisi BekciMurtaza = new GuvenlikGorevlisi();
            //BekciMurtaza.Ad = "Murtaza";
            //BekciMurtaza.Soyad = "Kaya";
            //KimlikKarti ahmet = new KimlikKarti() { TcNo="123"};
            //KimlikKarti mehmet = new KimlikKarti() { TcNo = "456" };
            //KimlikKarti ayse = new KimlikKarti() { TcNo = "789" };
            //KimlikKarti fatma = new KimlikKarti() { TcNo = "abc" };


            //GirisKarti girisKarti1= BekciMurtaza.GirisKartiVer(ahmet);
            //GirisKarti girisKarti2 = BekciMurtaza.GirisKartiVer(mehmet);
            //GirisKarti girisKarti3 = BekciMurtaza.GirisKartiVer(ayse);
            //GirisKarti girisKarti4 = BekciMurtaza.GirisKartiVer(fatma);
            //girisKarlari.Add(girisKarti1);
            //girisKarlari.Add(girisKarti2);
            //girisKarlari.Add(girisKarti3);
            //girisKarlari.Add(girisKarti4);


            //BekciMurtaza.KimlikleriListele();
            //Console.WriteLine("*** KArt Listesi *******");
            //BekciMurtaza.KimlikKartiVer(girisKarti1);
            //BekciMurtaza.KimlikleriListele();
            //Console.WriteLine("*** KArt Listesi *******");

            //BekciMurtaza.KimlikKartiVer(girisKarti2);
            //BekciMurtaza.KimlikleriListele();



            #endregion

            #region Fatura Kesim

            List<FaturaUrun> faturaUruns= new List<FaturaUrun>();

            FaturaMaster faturaMaster = new FaturaMaster();
            faturaMaster.Personel = new Personel() { TcNo="231321",AdSoyad="akjsdfahdf"}; ;
            faturaMaster.Musteri= new Musteri() { TcNo="qwedqwedq",AdSoyad="sdfsdfsdf"};
            FaturaUrun urun = new FaturaUrun()
            {
                Birim = FaturaKesim.Birim.Adet,
                UrunAdi = "Ekmek",
                Adet = 10,
                Fiyat = 5
           };
            faturaUruns.Add(urun);

            urun = new FaturaUrun()
            {
                Birim = FaturaKesim.Birim.gram,
                UrunAdi = "Peynir",
                Adet = 5000,
                Fiyat = 50
            };

            faturaUruns.Add(urun);
            
            FaturaMaster fat = new FaturaMaster();
            try
            {

                //bool sonuc = faturaMaster.FaturaKes();
                //if(sonuc)
                //{
                //    Console.WriteLine("Fartura Kesilmistir");
                //}


                //fat.FaturaKes(new Personel(),new Musteri(),faturaUruns);


                /*
                 
                 FaturtaMastyerYeni Class'indan bir instance alinabilmesi icin constructer 
                  icerisine gecilecek bagimli claslarin var olmasi gerekir.
                  Yoksa bu class'tan instance alinamaz.
                 */
                //1. Nesne
                Musteri musteri = new Musteri { TcNo = "sdfasdf", AdSoyad = "Ali Veli" };
                Personel personel = new Personel() { TcNo = "1242134", AdSoyad="Fatma" };

                List<FaturaUrun> faturaUrunleri = new();

                faturaUrunleri.Add(new FaturaUrun() { UrunAdi = "Peynir",Fiyat=120 });
                faturaUrunleri.Add(new FaturaUrun() { UrunAdi = "Ekmek",Fiyat=5 });
                faturaUrunleri.Add(new FaturaUrun() { UrunAdi = "Su" ,Fiyat = 5 });

                FaturaMasterYeni masterYeni = new FaturaMasterYeni(musteri,personel,faturaUrunleri);

                

                Console.WriteLine(masterYeni.ToString());
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            #endregion
        }
    }
}