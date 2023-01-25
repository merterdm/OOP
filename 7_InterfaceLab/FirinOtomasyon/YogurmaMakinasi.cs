using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_InterfaceLab.FirinOtomasyon
{
    public class YogurmaMakinasi:IYogur
    {
        public string MakinaAdi { get; set; }

        public void HamurYogur()
        {
            Console.WriteLine(MakinaAdi + " Hamur Yogurdu");
        }
    }
}
