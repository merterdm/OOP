using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Delegate
{
    public class ExternalMetodClass
    {

        public void TestMetod(int a, int b)
        {
            Console.WriteLine($"Bu metod vbaska bir class instance'i uzerinden calisti.\n Gelen Parametreler {a} , {b}"); ;
        }
    }
}
