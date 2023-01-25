using _6_OOP_Lab.Telefonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_OOP_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SmartPhone apple = null;
        SmartPhone Samsung = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            apple = new SmartPhone();
            apple.Marka = "Apple";
            apple.Fiyat = 20000;
            apple.Model = "IPhone70";
            apple.OS = OsType.Apple;
            //********************
            listBox1.Items.Add(apple);

            Samsung = new SmartPhone 
            { 
                OS = OsType.Android,
                Marka= "Samsung",
                Model="A50",
                Fiyat=20000
            
            };

            listBox1.Items.Add(Samsung);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();  

            ISmartPhone phone = (ISmartPhone)listBox1.SelectedItem;
            Label label = new Label() { Text="*Metodlar*"};
            flowLayoutPanel1.Controls.Add(label);
            foreach (var item in phone.GetType().GetMethods())
            {
                Label lbl = new Label()
                {
                    Text = item.Name,
                  //  Width = flowLayoutPanel1.Width

                };
                flowLayoutPanel1.Controls.Add(lbl);
            }
            Label label2 = new Label() { Text = "*Property'leri*" };
            flowLayoutPanel1.Controls.Add(label2);
            
            foreach (var item in phone.GetType().GetProperties())
            {
                Label lbl = new Label()
                {
                    Text = item.Name + "=>" + item.GetValue(phone),
                    //  Width = flowLayoutPanel1.Width

                };
                flowLayoutPanel1.Controls.Add(lbl);
            }
        }
    }
}
