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
    public partial class FormYonetGüncelleme : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=EMONN\\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True");
        public FormYonetGüncelleme()
        {
            InitializeComponent();
        }

        private void FormYonetGüncelleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet4.Yönetici' table. You can move, or remove it, as needed.
            this.yöneticiTableAdapter.Fill(this.otelDataSet4.Yönetici);

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Yönetici(YöneticiNck,YöneticiSifre) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtyad.Text);
            komut.Parameters.AddWithValue("@p2", txtysifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yönetici Eklendi.");
            this.yöneticiTableAdapter.Fill(this.otelDataSet4.Yönetici);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtyad.Text = ad;
            txtysifre.Text = sifre;
            txtyıd.Text = id;

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Yönetici where Yöneticiıd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",txtyıd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Gerçekleşti");
            this.yöneticiTableAdapter.Fill(this.otelDataSet4.Yönetici);

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("update Yönetici set YöneticiNck= @p1,YöneticiSifre=@p2 where Yöneticiıd=@p3",baglanti);
            komut.Parameters.AddWithValue("@p1",txtyad.Text);
            komut.Parameters.AddWithValue("@p2",txtysifre.Text);
            komut.Parameters.AddWithValue("@p3",txtyıd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı Güncellendi.");
            this.yöneticiTableAdapter.Fill(this.otelDataSet4.Yönetici);

        }
    }
}
