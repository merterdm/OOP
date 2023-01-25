using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP_Lab.Telefonlar
{
    public class BasePhone
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return Marka +" => "+ Model;
        }
    }
}
