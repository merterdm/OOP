using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_InterfaceLab.Guvenlik
{
    public  interface IGuvenlikGorevlisi
    {
        bool KimlikKontrolEt(KimlikKarti kimlik);
        GirisKarti GirisKartiVer(KimlikKarti kimlik);

        KimlikKarti KimlikKartiVer(GirisKarti girisKarti);
        

    }
}
