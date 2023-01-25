using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Emlak
{
    public class KonutDaire:BaseEmlak
    {
        public bool SiteIcerisindeMi { get; set; }
        public byte  KaciniKat { get; set; }

        public KonutDaire(Kimden kimden,int m2,int KacinciKat):base(kimden,m2)
        {
            
        }
        public override double KiraHesapla()
        {
            double kira = base.KiraHesapla();

            if(SiteIcerisindeMi) 
            {
                kira += 2000;
            }
            if (KaciniKat > 0)
            {
                kira += 500;
            }
            return kira;
        }
    }
}
