namespace _7_InterfaceLab.FaturaKesim
{
    


    public class FaturaDetay
    {



        public int FaturaDetayId { get; set; }
        public int FaturaNo { get; set; }
        public FaturaUrun Urun { get; set; }
        public decimal Miktar { get; set; }
        public decimal Fiyat { get; set; }
        public decimal IndirimOrani { get; set; }

    }
}