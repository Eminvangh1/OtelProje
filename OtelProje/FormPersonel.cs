using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelProje
{
    public partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
        }

        private void FormPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet5.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.otelDataSet5.Personel);

        }
      
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=EMONN\\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True");

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Personel  (PersonelAd, PersonelSoyad, PersonelDepertman) values (@p1,@p2,@p3)" ,baglanti);
            komut.Parameters.AddWithValue("@p1", txtpersonelad.Text);
            komut.Parameters.AddWithValue("@p2", txppersonelsoy.Text);
            komut.Parameters.AddWithValue("@p3", txtpersoneldepart.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Eklendi.");

        }
    }
}
