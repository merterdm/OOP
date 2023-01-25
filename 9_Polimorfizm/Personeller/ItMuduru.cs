using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Personeller
{
    
    public enum Persormans
    {
        Zayif=1,
        Orta,
        Iyi,
        CokIyi
    }

    public class ItMuduru:Yazilimci
    {
        public Persormans Performansi { get; set; }
        public override double MaasHesapla()
        {
            base.MaasHesapla();
            switch (Performansi)
            {
                case Persormans.Zayif:
                    Maas += Maas * (-0.1);
                    break;
                case Persormans.Orta:
                    Maas += Maas * 0.1;
                    break;
                case Persormans.Iyi:
                    Maas += Maas * 0.25;

                    break;
                case Persormans.CokIyi:
                    Maas += Maas * 0.5;

                    break;
                default:
                    break;
            }
            return Maas;
        }
    }
}
