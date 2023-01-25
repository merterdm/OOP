using System.Net.Http.Headers;

namespace _11_EventYangin
{
    internal class Program
    {
        public delegate void EventTip(object sender);
        static void Main(string[] args)
        {
            //Kablo Yanarsa Alarm Calar
            //Alarm Calarsa Itfaiye gelir
            //Alarm Calarsa Komsular Ratasiz Olur
            //Alarm Calarsa Insalar Kacar

            // Kablo 
            // Alarm
            // Itfaiye 
            // Komsular
            // Insanlar

            Kablo kablo = new Kablo();
            Alarm alarm = new Alarm();
            Itfaiye itfaiye = new Itfaiye();
            Insalar cemal = new Insalar("Cemal");
            Insalar ali = new Insalar("Ali");

            Komsular komsular = new Komsular();

            kablo.Yandim += alarm.AlarmCal;
            alarm.AlarmCaldi += itfaiye.MudahaleEt;
            alarm.AlarmCaldi += ali.RahatsizOl;
            alarm.AlarmCaldi += ali.Kac;
            alarm.AlarmCaldi += cemal.RahatsizOl;
            alarm.AlarmCaldi += cemal.Kac;
            alarm.AlarmCaldi += komsular.RatasizOl;

            kablo.AkimGecir();


            // olaylari Birbirine baglayalim

            
            
            Console.WriteLine("Hello, World!");
        }
    }
}