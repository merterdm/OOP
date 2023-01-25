using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AbstractClass.MuzikAletleri
{
    //Abstract classlar sadece kalitim vermek icin tasarlanmistir. Instance alinamazlar.
    // Yani new'lenemezler

    internal abstract class MuzikAleti
    {

        public string Marka { get; set; }
        public string Aciklama { get; set; }
        
        //Abstract Class larin en buyuk ozelligi de icerisinde Abstract olan yada olmayan metodlari barindirabilirler.
        // Abstract metodlar kalitim alinan yerde implimente edilmek zorundadir.
        //Yani Metodun govdesi kalitim alinan yerde yazilacaktir. InterfaceDeki gibi metod imzasi yeterlidir.
        public abstract string Cal();
        //public static  abstract string Cal(string ses);

        public virtual string AkortEt()
        {
            return Marka + " Akor Edildi";
                
       }
        


    }
}
