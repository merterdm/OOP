using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Class_AnotherProject.Mobilya
{
    public class YemekTakimi
    {
        public Masa Masa { get; set; }
        public List<Sandalye> Sandalye { get; set; }

        
        public YemekTakimi(int sandalyesayisi) 
        { 
            Sandalye = new List<Sandalye>();
            for (int i = 0; i < sandalyesayisi; i++)
            {
                Sandalye.Add(new Sandalye() {AyakSayisi=4,KumasTipi="TayTuyu",Renk="Beyaz",Malzeme=SandalyeMalzeme.Ahsap });
                

            }
        }
    }
}
