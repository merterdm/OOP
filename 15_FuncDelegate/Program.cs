using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System;

namespace _15_FuncDelegate
{
    internal class Program
    {
        //Func delegesi Action’a benzer bir yapıdadır ama Actiondan farklı olarak bir dönüş değeri vardır.
        //Func delegesinin tanımlarına baktığımızda iki farklı kullanım görebiliriz.Hiç parametre almadan bir değer dönebilir.
        // Func delegate T tipinden geri donus degeri olam metodlari temsil eder.

        /* Func<T>
         * Func<T,Tresult>
         * Func<T,T2,Tresult>
         * Func<T,T2.......,Tresult> 16 parametre alabilecek sekildedir
        */
        static void Main(string[] args)
        {
            int[] tamsayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            Func<string> stringDonenFunc;
            stringDonenFunc = merhabaDe;
            Console.WriteLine((stringDonenFunc()));

            Func<long, string> longAlipStringDonenFunc;
            longAlipStringDonenFunc = karesiniAl;
            Console.WriteLine(longAlipStringDonenFunc(3));

            Console.WriteLine("Hello, World!");
        }

        private static  string merhabaDe()
        {
            return "Merhaba";
        }

        private static string karesiniAl(long sayi)
        {
            return Math.Pow(sayi, 2).ToString();
        }
    }
}