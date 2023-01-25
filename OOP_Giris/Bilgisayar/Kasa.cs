using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Giris.Bilgisayar
{
    public class Kasa
    {
        public CPU Cpu { get; set; }
        public AnaKart Anakart { get; set; }
        public Ram Ram { get; set; }
        public HDD HDD { get; set; }
        public SSD SSD { get; set; }
        public EkranKarti EkranKarti { get; set; }

        public Ram Ram1
        {
            get => default;
            set
            {
            }
        }

        public SSD SSD1
        {
            get => default;
            set
            {
            }
        }

        public EkranKarti EkranKarti1
        {
            get => default;
            set
            {
            }
        }

        public CPU CPU
        {
            get => default;
            set
            {
            }
        }

        public AnaKart AnaKart
        {
            get => default;
            set
            {
            }
        }

        public HDD HDD1
        {
            get => default;
            set
            {
            }
        }

        public GucKaynagi GucKaynagi
        {
            get => default;
            set
            {
            }
        }
    }
}
