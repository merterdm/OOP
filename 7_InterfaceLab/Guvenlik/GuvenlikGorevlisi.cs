using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _7_InterfaceLab.Guvenlik
{
    public class GuvenlikGorevlisi : KisiBase, IGuvenlikGorevlisi
    {
        List<KimlikKarti> KimlikKartlari;

        int _kartNo = 0;
        //ilk calisan metodtur
        public GuvenlikGorevlisi() 
        {
            KimlikKartlari = new List<KimlikKarti>();
        }
        public GirisKarti GirisKartiVer(KimlikKarti kimlik)
        {
            GirisKarti girisKarti = new GirisKarti();
            girisKarti.GirisKartNo = ++_kartNo;
            girisKarti.Kimlik = kimlik;
            KimlikKartlari.Add(kimlik);
            return girisKarti;
        }

        public KimlikKarti KimlikKartiVer(GirisKarti girisKarti)
        {
            var kimlik = girisKarti.Kimlik;
            
            KimlikKartlari.Remove(kimlik);
            return kimlik;
        }

        public bool KimlikKontrolEt(KimlikKarti kimlik)
        {
            throw new NotImplementedException();
        }

        public void KimlikleriListele()
        {
            foreach (var item in KimlikKartlari)
            {
                Console.WriteLine(item.TcNo);
            }
        }
    }
}
