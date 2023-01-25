using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Hayvanlar
{
    public enum SolunumTipi:byte
    {
        Solungac=1,
        Akciger

    }

    public class Baliklar:BaseHayvan
    {
        public SolunumTipi SolunumTipi { get; set; }
    }
}
