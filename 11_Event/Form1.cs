using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Event
{
    public partial class Form1 : Form
    {
        // Bir olayin gerceklestigini belirten tetikleyicidir
        //Event tetiklendiginde onceden yazilmis kodlar calisacaktir.
        //Govdesiz metoda benzerler. Lakin handle etme sureci farklidir
        // Metod ne yapacagini bildigimiz ve ne zaman calisacagini bilgisimiz durumlarda calisir
        //Event Te en az iki obje vardir . Bir taraf ne yapilacagini bilir ama ne zaman yapilacagini bilmez
        // diger taraf ise ne zaman yapilacagini bilir. Ama ne yapilacagini bilmez
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TepkiGosteren tepkiGosteren = new TepkiGosteren();
            Bagiran bagiran=new Bagiran();
            bagiran.Bagirdim += tepkiGosteren.TepkiVer;
            bagiran.HErhangiBirIslemYap();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
