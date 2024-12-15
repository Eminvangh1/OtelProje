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
    public partial class Kayıt : Form
    {
        //Data Source=EMONN\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True;Encrypt=True;Trust Server Certificate=True
        public Kayıt()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EMONN\\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True");
        //SqlConnection nesnesi ile SQL Server veritabanına bağlantı açıyoruz
        private void Form1_Load(object sender, EventArgs e)
        {
            //Oda Listeleme
            baglanti.Open();

           
            
            SqlCommand komut = new SqlCommand("Select OdaNumarası From Odalar", baglanti);
             //"Odalar" tablosundan "OdaNumarası" sütunundaki verileri sorgulayan komut oluşturuluyor
           SqlDataReader oku= komut.ExecuteReader();
           // Komut çalıştırılarak veriler okuyoruz.
            while (oku.Read())
            // Okunan veriler ComboBox'a ekleniyor

            {
                combooda.Items.Add(oku[0].ToString());


            }
            baglanti.Close();


        }


        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                // Veritabanı bağlantısını açıyorum.
                SqlCommand komutkaydet = new SqlCommand("insert into Kayıt (Ad,Soyad,TC,Uyruk,Telefon, DoğumTarihi,OdaNumarası,Adres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
                // Kayıt komutunu oluşturuyoruz, kullanıcı bilgilerini Kayıt tablosuna ekliyoruz

               // Kullanıcıdan alınan veriler parametre olarak komuta ekleniyor
                komutkaydet.Parameters.AddWithValue("@p1", txtad.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", msktc.Text);
                komutkaydet.Parameters.AddWithValue("@p4", txtuyruk.Text);
                komutkaydet.Parameters.AddWithValue("@p5", masktelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p6", maskdogum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", combooda.Text);
                komutkaydet.Parameters.AddWithValue("@p8", richadres.Text);
                komutkaydet.ExecuteNonQuery();
                //Veritabanına verileri ekliyoruz.
                 baglanti.Close();
                //bağlantıyı kapatıyoruz. Kişi bilgileri girildiyse messagebox ile mesaj gönderiyoruz.
                MessageBox.Show("Kayıt Başarılı");

            
            }
            catch (Exception)
            {
                //Bir hata varsa kişi bilgileri girilirken kayıt yapılmıyor ve hata messajı gösteriyoruz.
                MessageBox.Show("Kayıt Başarısız");
            }
             

        }

      
    }
}
