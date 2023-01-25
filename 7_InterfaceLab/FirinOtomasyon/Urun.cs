using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_InterfaceLab.FirinOtomasyon
{
    public enum Birim
    {
        Adet,Gram,Mlitre
    }

    public class Urun
    {
        public string Isim { get; set; }
        public decimal Mitar { get; set; }
        public Birim Birim { get; set; }

        public decimal Fiyat { get; set; }
    }
}
