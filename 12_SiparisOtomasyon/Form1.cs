﻿using _12_SiparisOtomasyon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _12_SiparisOtomasyon.Entities;
using _12_SiparisOtomasyon.Forms;

namespace _12_SiparisOtomasyon
{
    public partial class Form1 : Form
    {
        public static List<Siparis> Siparisler = new List<Siparis>();
        public static List<Siparis> MevcutSiparis = new List<Siparis>();
        public static List<_12_SiparisOtomasyon.Entities.Menu> Menuler = new List<Entities.Menu>()
        {
            new _12_SiparisOtomasyon.Entities.Menu {MenuAdi="Whooper" ,Fiyat=120},
            new _12_SiparisOtomasyon.Entities.Menu {MenuAdi="BigKing" ,Fiyat=130},
            new _12_SiparisOtomasyon.Entities.Menu {MenuAdi="King Chicken " ,Fiyat=90},
            new _12_SiparisOtomasyon.Entities.Menu {MenuAdi="King Sezar Salata" ,Fiyat=80},
            new _12_SiparisOtomasyon.Entities.Menu {MenuAdi="BigFish" ,Fiyat=120}
        };



        public static List<Extra> Extralar = new List<Extra>()
        {
            new Extra(){ ExtraAdi="Ketcap", Fiyat=5},
            new Extra(){ ExtraAdi="Mayonez", Fiyat=5},
            new Extra(){ ExtraAdi="Hardal", Fiyat=5},
            new Extra(){ ExtraAdi="Sogan Halkasi", Fiyat=7},
            new Extra(){ ExtraAdi="Rach", Fiyat=5},

        };

        public Form1()
        {
            InitializeComponent();
        }

        private void mEnuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.MdiParent = this;
            frmMenu.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSiparis frmSiparis = new frmSiparis();
            frmSiparis.MdiParent = this;
            frmSiparis.Show();
            
        }

        private void extraEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtra frmExtra = new frmExtra();
            frmExtra.MdiParent = this;
            frmExtra.Show();
        }

        private void raporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSiparisRapor rapor = new frmSiparisRapor();
            rapor.MdiParent = this;
            rapor.Show(); 
        }
    }
}
