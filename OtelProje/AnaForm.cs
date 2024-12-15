using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProje
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet1.Kayıt' table. You can move, or remove it, as needed.
            this.kayıtTableAdapter.Fill(this.otelDataSet1.Kayıt);
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // lblere saat ve tarihi ekliyor.
            lblsaat.Text = DateTime.Now.ToLongTimeString();
            lblzaman.Text = DateTime.Now.ToLongDateString();    
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Uygulama dışından hesap makinesini çağırıyoruz.
            System.Diagnostics.Process.Start("Calc.exe");

        }

        private void kayıtEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kayıt frm =  new Kayıt();
            frm.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiderler frm = new FormGiderler();
            frm.Show();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiderListele frm = new FormGiderListele();
            frm.Show();

        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYonetGüncelleme frm = new FormYonetGüncelleme();
            frm.Show();

        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel frm = new Personel();
            frm.Show();

        }

        private void kayıtListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayıtList frm = new KayıtList();
            frm.Show();

        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
