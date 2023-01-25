using static _11_EventYangin.Program;

namespace _11_EventYangin
{
    internal class Alarm
    {
        public event EventTip AlarmCaldi;
        public Alarm()
        {
        }

        public void AlarmCal(object alarmiTetikleyen)
        {
            if (alarmiTetikleyen is Kablo)
            {
                Console.WriteLine("Alarm Caldi");
                AlarmCaldi(this);
            }
            else if (alarmiTetikleyen is Sigara)
            {
                Console.WriteLine("Sigara yandi alarm caldi");
            }
        }
    }
}