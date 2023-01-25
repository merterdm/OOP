using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class_EnCapsulatin
{
    public  class Personel
    {
        public string Ad;
        public string Soyad;
        private  string _TcNo;

        // Kontrollu veri girisi sagladik
        public string SetTcNo(string TcNo)
        {
            if(string.IsNullOrEmpty(TcNo)) 
            {
                return "TcNo Boş olamaz";
            }
            if(TcNo.Length != 11) 
            {

                return "TcNo En az 11 Karakter olmalidir";
            }
            for (int i = 0; i < TcNo.Length; i++)
            {
                if (!char.IsDigit(TcNo[i]))
                    return "Sayisal Deger Giriniz";
            }
            _TcNo = TcNo;
            return "ok";
        }
        // TcNumarasinin son 3 hanesini gosterecek sekilde disari gonderiyoruz.
        public string GetTcNo()
        {
            string temp = "";
            for (int i = 0; i < _TcNo.Length; i++)
            {
                if (i > 8)
                {
                    temp += _TcNo[i];
                }
                else
                {
                    temp += "*";
                }
            }
            return temp;
        }

    }
}
