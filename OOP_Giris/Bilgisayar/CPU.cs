using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Giris.Bilgisayar
{
    /*
     Enumlar default olarak integer veri tipindedir. 
     istenirse degistirilebilir.
      secmeli durumlarda kullanilir.
    Her bir duruma bir numara verir.
    Eger numara verme isek 0'dan baslar

     */
    public enum IslemciTipi:byte
    {
        AMD=1,
        Intel,
        MSeries
    }

    public class CPU
    {
        public string Marka { get; set; }
        public string Model{ get; set; }

        public string IslemciNesli { get; set; }
        public string SocketYapisi { get; set; }
        public IslemciTipi IslemciTipi { get; set; }
        public byte CekirdekSayisi { get; set; }
        public string Frekans { get; set; }

        public IslemciTipi IslemciTipi1
        {
            get => default;
            set
            {
            }
        }
    }
}
