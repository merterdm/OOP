using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_InterfaceLab.FirinOtomasyon
{
    public class Firin
    {
       


        public void EkmekPisir(List<Urun> malzemeler ,Usta usta)
        {
            usta.HamurYogur();
            foreach (var item in malzemeler)
            {
                global::System.Console.WriteLine(item.Mitar + " " + item.Birim);
            }

        }
        public void EkmekPisir(List<Urun> malzemeler, YogurmaMakinasi makina)
        {
            makina.HamurYogur();
            foreach (var item in malzemeler)
            {
                global::System.Console.WriteLine(item.Mitar + " " + item.Birim);
            }

        }


        public void EkmekPisir(List<Urun> malzemeler, IYogur yogurucu)
        {
            yogurucu.HamurYogur();
            foreach (var item in malzemeler)
            {
                global::System.Console.WriteLine(item.Mitar + " " + item.Birim);
            }

        }
    }
}
