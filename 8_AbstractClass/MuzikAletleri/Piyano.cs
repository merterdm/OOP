using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AbstractClass.MuzikAletleri
{
    internal class Piyano : MuzikAleti
    {

        //public abstract string Test();
        public override string Cal()
        {
            return "Piyano sesi";
        }
    }
}
