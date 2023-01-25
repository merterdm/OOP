using _12_SiparisOtomasyon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_SiparisOtomasyon.Forms
{
    public partial class frmSiparisRapor : Form
    {
        public frmSiparisRapor()
        {
            InitializeComponent();
        }

        private void frmSiparisRapor_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal extraMalzemeGeliri=0;
            int SatisAdedi = 0;

            foreach (Siparis siparis in Form1.Siparisler)
            {
                ciro += siparis.ToplamTutar;
                foreach (var extra in siparis.Extralar)
                {
                    extraMalzemeGeliri += extra.Fiyat;
                }
                SatisAdedi++;
            }

            lblCiro.Text= ciro.ToString("C2");
            lblExtra.Text = extraMalzemeGeliri.ToString("C2");
            label1.Text = SatisAdedi.ToString();
        }
    }
}
