using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP_Lab
{
    public  class MyDbConnection
    {
        private  static MyDbConnection _myDbConnection;

        

        public static MyDbConnection GetConnection()
        {
            if (_myDbConnection == null)
            {
                _myDbConnection= new MyDbConnection();
            }
            return _myDbConnection;
        }


        private MyDbConnection()
        {

        }
    }


    public class SingletonExample
    {

        private static SingletonExample instance;

        private SingletonExample() { }

        public static SingletonExample getInstance()
        {

            if (instance == null)
            {
                instance = new SingletonExample();
            }

            return instance;
        }
    }
}
