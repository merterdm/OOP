using _2_Class_AnotherProject.Mobilya;
using OOP_Giris.Bilgisayar;

namespace OOP_Giris
{

    // Internal Class
    public class Personel
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        private string TcNo;
        // Kontrollu veri girisi
        public string SetTcNo(string kimlikno)
        {
            if(string.IsNullOrEmpty(kimlikno)) 
            {
                return "TcNo boş olamaz";
            }
            else
            {
                if(kimlikno.Length!=11) 
                {
                    return "Tcno 11 karakter uzunlugunda olmalidir";
                }
                
                TcNo = kimlikno; 
            }
            return "Ok";
        }


        public string GetTcNo()
        {
            string temp = "";
            for (int i = 0; i < TcNo.Length; i++)
            {
               
                if(i>=8)
                    temp += TcNo[i];
                else
                    temp += "*";

            }
            return temp; 
        }

        public string TcNo2 {
            get {

                string temp = "";
                for (int i = 0; i < TcNo.Length; i++)
                {

                    if (i >= 8)
                        temp += TcNo[i];
                    else
                        temp += "*";

                }
                return temp;
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    return ;
                }
                else
                {
                    if (value.Length != 11)
                    {
                        return ;
                    }

                    TcNo = value;
                }

            } 
        }

        public DateTime DogumTarihi{ get; set; }


        private string KrediKartNo;


    }

   

    internal class Program
    {
        

        static void Main(string[] args)
        {

            Personel ali = new Personel();

            Console.WriteLine(ali.SetTcNo("12345678901"));
            Console.WriteLine(ali.GetTcNo());


            #region Class'lardan instance alma

            //1. Yol
            Ram ram = new Ram();

            //2. Yol 
            Ram ram2 = new();
            ram2.Marka = "Samsung";
            ram2.Model = "DDR3";


            // 3. Yol 
            // Object initilace ile nesneden ornek alma yontemi
            Ram ram3 = new() {
                Marka="Samsung" ,
                Model="DDR4" ,
                Kapasite="8GB" ,
                KullanimTipi="Bilgisayar",
                RamHizi="4000 Hz"
            };

            #endregion
            SSD ssd = new() {Marka="Seagete",Model="Chita" ,Kapasite="1 TB",BaglantiTipi="Socket3" ,Kalinlik="10mm" ,OkumaYazmaHizi="500/650"};


            AnaKart anaKart = new()
            {
                Marka = "Asus",
                Model = "XYZ skjdfjks",
                DahiliEkranKarti = true,
                IslemciSocketTipi = "lksdf",
                Overclock=true,
                Wifi=true
                
            
            };

            GucKaynagi guc = new() { Marka = "asdasd", Model = "500", Watt = "500 Watt" };

            CPU cPU = new()
            {
                Marka = "Intel",
                Model = "9.NEsil",
                IslemciTipi = IslemciTipi.Intel,
                CekirdekSayisi = 10,
                SocketYapisi = "sdf",
                Frekans = "5000hrzt"
            };


            Kasa kasa = new() 
            { 
                Anakart = anaKart, 
                Cpu = cPU, 
                SSD = ssd, 
                Ram = ram3 
            };
            Test test = new Test();
            Console.WriteLine(kasa.ToString());
            Console.WriteLine(ali.ToString());
            Console.WriteLine(test.ToString());


            // External Project Referans Kullanimi

            //1. Kullanim. Boş Constructer
            Masa masa = new Masa();


            //2. Kullanim. Parametreleri Kullanim
            Masa masa1 = new Masa(5);

            //3. Kullanim. Parametreleri Kullanim
            Masa masa2 = new Masa(5,"Mavi");


            //3. Kullanim. Parametreleri Kullanim
            Masa masa3 = new Masa(5, "Mavi",Malzeme.Ahsap);

            //4. Kullanim

            Masa masa5 = new Masa();
            masa5.AyakSayisi = 10;
            masa5.Malzeme = Malzeme.Ahsap;
            masa5.Renk = "siyah";



            // YemekTakimi
            YemekTakimi takim = new YemekTakimi(4);
            takim.Masa = masa5;
           
           Test test1= new Test();  
            object obj = new object();

           

            Console.ReadLine();
        }
    }

    public class Test
    {

    }
}