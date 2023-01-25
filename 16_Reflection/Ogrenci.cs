using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Reflection
{
    internal class Ogrenci : BaseKisi, IOgrenci
    {
        public bool DerseGir()
        {
            Console.WriteLine(AdSoyad + " Derse Girdi");
            return true;    
        }

        public bool EfendiOl()
        {
            throw new NotImplementedException();
        }

        public bool OkulaGel()
        {
            throw new NotImplementedException();
        }
    }
}
