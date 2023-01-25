namespace _11_EventYangin
{
    internal class Komsular
    {
        public Komsular()
        {
        }

        public void RatasizOl(object rahatsizEden)
        {
            if(rahatsizEden is Alarm) 
            {
                Console.WriteLine("Komsular Rahatsiz Oldu");
            }
        }
    }
}