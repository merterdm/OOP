using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class_EnCapsulatin
{
    public class Personel2
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        private string _TcNo;

        public string TcNo {
            get 
            {
                string temp = "";
                if (_TcNo != null)
               {
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
                }
                return temp;
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    return;
                }
                if (value.Length != 11)
                {

                    return ;
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsDigit(value[i]))
                        return ;
                }

                _TcNo = value;

            } 
        
        }

    }
}
