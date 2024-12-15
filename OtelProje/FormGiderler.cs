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
    public partial class FormGiderler : Form
    {

        public FormGiderler()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
        SqlConnection baglanti = new SqlConnection("Data Source=EMONN\\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True");

            try
            {
             baglanti.Open();
                //Veritabanına veri eklemek için bir SQL komutu oluşturuyoruz.
             SqlCommand komut = new SqlCommand("insert into OtelGiderler(Elektrik,Su,Doğalgaz,Gıda,Diğer)values (@p1,@p2,@p3,@p4,@p5)", baglanti);
               // Parametreler ekleniyor kullanıcının formda girdiği değerleri SQL komutunun parametrelerine bağlanıyor.
             komut.Parameters.AddWithValue("@p1",txtelektrik.Text);
             komut.Parameters.AddWithValue("@p2",txtsu.Text);
             komut.Parameters.AddWithValue("@p3",txtdoğalgaz.Text);
             komut.Parameters.AddWithValue("@p4",txtgıda.Text);
             komut.Parameters.AddWithValue("@p5",txtdiğer.Text);
             komut.ExecuteNonQuery();
             baglanti.Close();
                //bağlantıyı kapatıyoruz.
                MessageBox.Show("Giderler Eklendi.");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
            
            


        }
    }
}
