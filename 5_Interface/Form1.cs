using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Kaleci muslera = new Kaleci();
        
        Defans TakozRecep = new Defans()
            {
                AdiSoyadi = "Takoz Recep",
                FormaNumarasi = 3,
                Agresiflik = 80,
                SutGucu = 95,
                Milli = true,
                Refleks = 90

            };
        Forvet CenkTosun = new Forvet
        {
            AdiSoyadi = "Cenk Tosun",
            FormaNumarasi = 23,
            Agresiflik = 80,
            Milli = true,
            Refleks = 80,
            SutGucu = 90
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            muslera.AdiSoyadi = "Muslera ";
            muslera.SutGucu = 90;
            muslera.Agresiflik = 30;
            muslera.Refleks = 95;
            muslera.Milli = true;
            muslera.FormaNumarasi = 1;

            listBox1.Items.Add(muslera);

            
            listBox1.Items.Add(TakozRecep);

            

            listBox1.Items.Add(CenkTosun);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            //Reflections : Bir class yada interface ierisindeki metod yada proplari cozumleme durumana denir
            var props = TakozRecep.GetType().GetProperties();

          
            if(listBox1.SelectedItem!= null && listBox1.SelectedItem.GetType().GetInterface("IFutbolcu")!=null) 
            {

                IFutbolcu futbolcu = (IFutbolcu)listBox1.SelectedItem;

                foreach (var prop in futbolcu.GetType().GetProperties())
                {
                    Label lbl = new Label();
                    lbl.Text = prop.Name + ":" + prop.GetValue(futbolcu);
                    lbl.AutoSize = false;
                    lbl.Width = flowLayoutPanel1.Width;
                    flowLayoutPanel1.Controls.Add(lbl); 
                }





            }






        }
    }
}
