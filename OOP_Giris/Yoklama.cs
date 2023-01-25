using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Giris
{
    public class Yoklama
    {
        public Ogrenci Ogrenci { get; set; }
        public Egitmen Egitmen { get; set; }
        public List<DateTime> Gunler { get; set; }
        public List<bool> Imza { get; set; }
    }
}
