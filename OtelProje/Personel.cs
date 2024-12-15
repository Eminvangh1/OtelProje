using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelProje
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet7.Personel' table. You can move, or remove it, as needed.
           // Bu satır 'otelDataSet7.Personel' tablosundaki verileri yüklüyor.
            this.personelTableAdapter.Fill(this.otelDataSet7.Personel);
            //Personel tablosundaki verilere veri çekmek, güncellemek veya silmek gibi işlemler yapmak için kullanılır.

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=EMONN\\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelAd,PersonelSoyad,PersonelDepartman) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtpersonelad.Text);
            komut.Parameters.AddWithValue("@p2", txppersonelsoy.Text);
            komut.Parameters.AddWithValue("@p3", txtpersoneldepart.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Eklendi.");
            this.personelTableAdapter.Fill(this.otelDataSet7.Personel);
            // Tekrar eklenmenin sebebi güncelleme yapması. Formda personel sildikten sonra formun güncellenmesini sağlıyor.
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
           // Veritabanına bağlanmak için SqlConnection nesnesi oluşturuyoruz.
             // Bağlantı dizesi, Data Source  Initial Catalog
               //  Integrated Security (güvenlik parametreleri) ile bağlantı sağlanır.
            SqlConnection baglanti = new SqlConnection("Data Source=EMONN\\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True");
            baglanti.Open();

            SqlCommand komutsil = new SqlCommand("Delete from Personel Where PersonelID=@p1", baglanti);
            komutsil.Parameters.AddWithValue("@p1", txtpersonelıd.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
            this.personelTableAdapter.Fill(this.otelDataSet7.Personel);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection("Data Source=EMONN\\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True");
            baglanti.Open();
            SqlCommand komutguncel = new SqlCommand("update Personel set PersonelAd=@p1, PersonelSoyad=@p2,PersonelDepartman=@p3 where PersonelID=@p4", baglanti);
            komutguncel.Parameters.AddWithValue("@p1",txtpersonelad.Text);
            komutguncel.Parameters.AddWithValue("@p2",txppersonelsoy.Text);
            komutguncel.Parameters.AddWithValue("@p3",txtpersoneldepart.Text);
            komutguncel.Parameters.AddWithValue("@p4",txtpersonelıd.Text);
            komutguncel.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");
            this.personelTableAdapter.Fill(this.otelDataSet7.Personel);

        }
    }
}
