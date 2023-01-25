using System.Reflection.Metadata;
using System;

namespace _14_ActionDelegate
{
    internal class Program
    {
        //Action delege türü hiçbir parametre almayan ve değer döndürmeyen metodları temsil eder.
        //Adından da anlaşılacağı üzere bir fonksiyonu değil bir eylemi(action) temsil etmektedirler.

        delegate void NormalDelege(long sayi);
        static void Main(string[] args)
        {
            // Normal delege ile yyapildiginda olan kodlar
            NormalDelege kareal;
            kareal = karesiniAl;
            kareal(10);

            //ACTİON DELEGE İLE YAPİLAN KODLAR 
            Action<long> actionIleKaresiniAl;
            actionIleKaresiniAl = karesiniAl;
            actionIleKaresiniAl(3);


        }

        private static void karesiniAl(long sayi)
        {
            Console.WriteLine((Math.Pow(sayi, 2).ToString()));
        }
    }
}