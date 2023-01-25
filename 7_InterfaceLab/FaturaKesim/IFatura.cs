using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_InterfaceLab.FaturaKesim
{
    public interface IFatura
    {

        bool FaturaKes();
        bool FaturaKes(Personel personel);
        bool FaturaKes(Personel personel, Musteri musteri);

        bool FaturaKes(Personel personel, Musteri musteri, List<FaturaUrun> urunler);

    }
}
