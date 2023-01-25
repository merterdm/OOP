using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Class_AnotherProject.Mobilya
{
    public enum Malzeme
    {
        Ahsap=1,
        Demir,
        Celik,
        Plastik
    }

    public class Masa
    {
        public int AyakSayisi {  get; set; }
        public string Renk { get; set; }
        public Malzeme Malzeme { get; set; }

        /*
         Constructer : Yapici Metod . 
         Nesne ilk olarak new'lendigi zaman calisan metoddur.
         Yapici metodlarin geri donus degerleri yoktur.
         O yuzden sadece class'lar ozel metoddur
         */


        // Herhangi bir parametre almayabn yapici metoddur.
        // Boş Constructer da denir.
        public Masa() 
        { 
        
        }
        public Masa(int ayaksayisi)
        {
            AyakSayisi = ayaksayisi;
        }
        public Masa(int ayaksayisi,string renk)
        {
            AyakSayisi = ayaksayisi;
            Renk = renk;
        }

        public Masa(int ayaksayisi, string renk,Malzeme malzeme)
        {
            AyakSayisi = ayaksayisi;
            Renk = renk;
            Malzeme = malzeme;
        }
    }
}
