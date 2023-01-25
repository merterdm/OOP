using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Class_AnotherProject.Mobilya
{
    public enum SandalyeMalzeme
    {
        Ahsap = 1,
        Demir,
        Celik,
        Plastik
    }

    public class Sandalye
    {
        public int AyakSayisi { get; set; }
        public string Renk { get; set; }
        public string KumasTipi { get; set; }

        public SandalyeMalzeme Malzeme { get; set; }
    }
}
