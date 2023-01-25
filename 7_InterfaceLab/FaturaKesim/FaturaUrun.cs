using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_InterfaceLab.FaturaKesim
{
    public enum Birim
    {
        Adet,
        gram,
        mililitre
    }

    public class FaturaUrun
    {
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Adet { get; set; }
        public Birim Birim { get; set; }
    }
}
