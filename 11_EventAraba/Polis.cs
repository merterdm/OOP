using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_EventAraba
{
    internal class Polis:Insan
    {
        public Polis(string ad):base(ad)
        {

        }
        
        public void HizKontrolEt(int hiz, object tetikleyen)
        {
            if (tetikleyen is Araba)
            {
                if (hiz > 120)
                {
                    Araba araba = (Araba)tetikleyen;
                    araba.ArabaCalisiyorMu = false;
                    Console.WriteLine($"{araba.Plaka} plakali aracin {araba.Sofor.Ad} isimli şöförüne\n {hiz} km hizla gittiginden dolayi {Ad} isimli polis tarafindan ceza kesilmistir.");
                        
                    
                }
            }
        }
    }
}
