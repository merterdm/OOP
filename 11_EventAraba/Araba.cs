namespace _11_EventAraba
{
    internal class Araba
    { 
        
        public event ArabaDelegate HareketEdiyorum;
        
        
        
        private int maxHiz;
       
        public Araba(string plaka,int maxHiz)
        {
            Plaka = plaka;
            this.maxHiz = maxHiz;
        }
        public Sofor Sofor { get; set; }

        public string Plaka { get; private set; }
        public bool ArabaCalisiyorMu { get; set; }

        public void Calis(int gazOrani, object gazaBasan)
        {
            Sofor = (Sofor)gazaBasan;
            int hiz = HizHesapla(gazOrani);
            ArabaCalisiyorMu = true;
            Console.WriteLine($"Araba {hiz} km hizla gidiyor..");
            while (ArabaCalisiyorMu)
            {
                HareketEdiyorum(hiz, this);
            }
        }

        private int HizHesapla(int gazOrani)
        {
            return maxHiz * gazOrani / 100;
        }
    }
}