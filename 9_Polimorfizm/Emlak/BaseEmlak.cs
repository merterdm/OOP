﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Emlak
{
    public enum EmlakTipi
    {
        Daire=1,
        Residance,
        MustakilEv,
        Villa,
        CiftlikEvi,
        Köşk,
        Yali,
        YaliDairesi,
        Yazlik

    }
    public enum Kimden
    {
        Sahibinden=1,
        Emlakcidan,
        InsaatFirmasindan
    }

    public abstract class BaseEmlak
    {
        public DateTime IlanTarihi { get; set; }
        public EmlakTipi EmlakTipi { get; set; }
        private int _m2 =50;
        private int _m2base = 50;
        public int M2
        {
            get { return _m2 ; }
            set { _m2 = value; }
        }

        public BaseEmlak(Kimden kimden,int m2)
        {
            Kimden = kimden;
            M2 = m2;
        }


        public byte OdaSayisi { get; set; }
        public byte BinaYasi { get; set; }
        public Kimden Kimden { get; set; }
        public bool EsyaliMi { get; set; }

        private double _kira=2500;

        public double Kira
        {
            get { return _kira; }
            private set { _kira= value; }
        }



        public virtual double KiraHesapla()
        {
            int m2 = M2 - _m2base;
            //m2 basina 100 Tl fark
            Kira += m2 * 100;
            
            if(EsyaliMi) 
            {
                Kira += 1000;
            }
            
            
            return Kira;
        }
        public virtual double KomisyonHesapla()
        {
            double kira = KiraHesapla();
            return kira * 12 * 0.1;
        }
    }
}
