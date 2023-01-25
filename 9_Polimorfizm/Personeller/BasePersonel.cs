using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Personeller
{
    public enum EgitimDurumu
    {
        Lise=1,
        Universite,
        YuksekLisans,
        Doktora
    }

    public abstract class BasePersonel
    {
        public string AdSoyad { get; set; }
        public string TcNo { get; set; }
        public int CocukSayisi { get; set; }
        public EgitimDurumu EgitimDurumu { get; set; }

        private double _Maas =5000;
       
        public double Maas
        {
            get { return _Maas; }
            set { _Maas = value; }
        }
        public virtual double MaasHesapla()
        {
            if (CocukSayisi > 0)
            {
                Maas += CocukSayisi * 100;
            }

            switch (EgitimDurumu)
            {
                case EgitimDurumu.Lise:
                    break;
                case EgitimDurumu.Universite:
                    Maas += Maas * 0.2;
                    break;
                case EgitimDurumu.YuksekLisans:
                    Maas += Maas * 0.3;

                    break;
                case EgitimDurumu.Doktora:
                    Maas += Maas * 0.4;

                    break;
                default:
                    break;
            }

            return Maas;
        }

    }
}
