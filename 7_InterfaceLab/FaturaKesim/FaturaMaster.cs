using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_InterfaceLab.FaturaKesim
{
    public enum FaturaTipi
    {
        Alis=1,
        Satis,
        Iade
    }

    public class FaturaMaster:IFatura
    {
        public Personel Personel{ get; set; }
        public Musteri Musteri { get; set; }
        public DateTime KesimTarihi { get; set; }
        public int FaturaNo { get; set; }
        public FaturaTipi FaturaTipi { get; set; }
        public List<FaturaDetay> FaturaDetaylari { get; set; }

        public bool FaturaKes()
        {

            if (Personel == null)
            {
                throw new Exception("Personel bilgisi olmadan fatura kesemezsiniz");
            }
            if (Musteri == null)
            {
                throw new Exception("Musteri bilgisi olmadan fatura kesemezsiniz");

            }

            if (FaturaDetaylari == null)
            {
                throw new Exception("Fatura Detay  bilgisi olmadan fatura kesemezsiniz");

            }

            // Fatura Kesildi:Db'ye kaydedildi
            return true;
        }

        public bool FaturaKes(Personel personel)
        {
            if (Musteri == null)
            {
                throw new Exception("Musteri bilgisi olmadan fatura kesemezsiniz");

            }

            if (FaturaDetaylari == null)
            {
                throw new Exception("Fatura Detay  bilgisi olmadan fatura kesemezsiniz");

            }

            // Fatura Kesildi:Db'ye kaydedildi
            return true;
        }

        public bool FaturaKes(Personel personel, Musteri musteri)
        {

            if (FaturaDetaylari == null)
            {
                throw new Exception("Fatura Detay  bilgisi olmadan fatura kesemezsiniz");

            }

            // Fatura Kesildi:Db'ye kaydedildi
            return true;
        }

        public bool FaturaKes(Personel personel, Musteri musteri, List<FaturaUrun> urunler)
        {
            return true;
        }
    }
}
