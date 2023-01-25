using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Reflection
{
    internal class Sinif
    {
        public List<Ogrenci> Ogrenciler { get; set; }
        public Ogretmen Ogretmen { get; set; }

        public int Kapasite { get; set; }

        public Sinif()
        {
            Ogrenciler= new List<Ogrenci>();    
        }
    }
}
