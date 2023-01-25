using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Giris
{
    public class Ogrenci
    {
        public string Ad { get; set; }//Boş prop .
        public string Soyad { get; set; } //Boş
        public string TcNo { get; set; } // Boş

        #region Full Prop => Kontrollu veri giris cikisi
        private string _KrediKartNo;

        public string KeridiKartNo
        {
            get { return _KrediKartNo.Substring(12); }
            set { 
                
                if (value.Length != 16)
                {
                    throw new Exception("Krei Karti 16 Karakter olmalidir");
                }
                else if(!string.IsNullOrEmpty(value)) 
                {
                    throw new Exception("Kredi Karti Boş olamaz");
                }
                else
                _KrediKartNo = value; 
            
            
            }
        } 
        #endregion

    }
}
