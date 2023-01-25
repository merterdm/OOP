using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _7_InterfaceLab.FaturaKesim
{
    public class FaturaMasterYeni
    {
        private readonly Musteri musteri;
        private readonly Personel personel;
        private readonly List<FaturaUrun> urunler;
        private List<FaturaDetay> faturaDetaylari;
        private int _faturaNo;
        public DateTime KesimTarihi { get; private set; }
        public int FaturaNo { get; private set; }
        public FaturaTipi FaturaTipi { get; set; }
        

        public FaturaMasterYeni(Musteri musteri,Personel personel,List<FaturaUrun> urunler)
        {
            this.musteri = musteri;
            this.personel = personel;
            this.urunler = urunler;
            this.FaturaTipi = FaturaTipi.Alis;
            this.FaturaNo = ++_faturaNo;
            this.KesimTarihi = DateTime.Now;
            List<FaturaDetay> faturaDetaylari = new List<FaturaDetay>();
            foreach (var urun in urunler)
            {
                faturaDetaylari.Add(new FaturaDetay() { FaturaNo = _faturaNo, Urun = urun, Fiyat = urun.Fiyat, Miktar = urun.Adet });
            }
        }

        public override string ToString()
        {
            string str = "Fatura No :" + _faturaNo + " " + "Kesim Tarihi:" + KesimTarihi + "\n";
          

            str += "Personel :" + personel.AdSoyad + "  Musteri:" + musteri.AdSoyad + "\n";
            foreach (var urun in urunler)
            {
                str += urun.UrunAdi + " " + urun.Adet + " " + urun.Fiyat + "\n";
            }


            return str;
        }
    }
}
