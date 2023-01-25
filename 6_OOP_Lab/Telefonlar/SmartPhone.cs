using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP_Lab.Telefonlar
{
    public enum OsType
    {
        Apple,
        Android,
        HarmonyOs
    }

    public class SmartPhone:BasePhone , ISmartPhone
    {
        public OsType OS { get; set; }

        public void AnswerCall()
        {
            throw new NotImplementedException();
        }

        public void Call()
        {
            throw new NotImplementedException();
        }

        public void PlaySnakeGame()
        {
            throw new NotImplementedException();
        }

        public void ReceiveSms()
        {
            throw new NotImplementedException();
        }

        public void SendSms()
        {
            throw new NotImplementedException();
        }

        public void TakePicture()
        {
            throw new NotImplementedException();
        }

        public void UseInternet()
        {
            throw new NotImplementedException();
        }

        public void UseMaps()
        {
            throw new NotImplementedException();
        }
    }
}
