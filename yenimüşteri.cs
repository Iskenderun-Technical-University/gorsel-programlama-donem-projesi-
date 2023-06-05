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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data.Sql;
using System.Data.SqlClient;
namespace otomasyon
{
    public partial class yenimüşteri : Form
    {
        public yenimüşteri()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=CRAZYY\\SQLEXPRESS01;Initial Catalog=otamosyon;Integrated Security=True");
        private void btnoda101_Click(object sender, EventArgs e)
        {
            txtoda.Text = "101";
        }

        private void btnoda102_Click(object sender, EventArgs e)
        {
            txtoda.Text = "102";
        }

        private void btnoda103_Click(object sender, EventArgs e)
        {
            txtoda.Text = "103";
        }

        private void btnoda104_Click(object sender, EventArgs e)
        {
            txtoda.Text = "104";
        }

        private void btnoda105_Click(object sender, EventArgs e)
        {
            txtoda.Text = "105";
            
            
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105 (Adi,Soyadi) values ( '" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void btnoda106_Click(object sender, EventArgs e)
        {
            txtoda.Text = "106";
        }

        private void btnoda107_Click(object sender, EventArgs e)
        {
            txtoda.Text = "107";
        }

        private void btnoda108_Click(object sender, EventArgs e)
        {
            txtoda.Text = "108";
        }

        private void btnoda109_Click(object sender, EventArgs e)
        {
            txtoda.Text = "109";
        }

        private void btndoluoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kırmızı renkli odalar dolu olduğunu gösterir");
        }

        private void btnboşoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("gri renkli odalar boş olduğunu gösterir");
        }

        private void dtpçıkış_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih=Convert.ToDateTime(dtpgiriş.Text);
            DateTime buyuktarih=Convert.ToDateTime(dtpçıkış.Text);

            TimeSpan sonuc=buyuktarih-kucukTarih;

            label10.Text = sonuc.TotalDays.ToString();    
            ucret=Convert.ToInt32(label10.Text)*50;
            richTextBox1.Text = ucret.ToString();   

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbcinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsoyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void msktxttel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglantı = new SqlConnection("Data Source=CRAZYY\\SQLEXPRESS01;Initial Catalog=otamosyon;Integrated Security=True");
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into MüsteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ücret,GirisTarihi,ÇıkısTarihi) values ( ' " + txtadi.Text + "','" + txtsoyadi.Text + "','" + cmbcinsiyet.Text + " ','" + msktxttel.Text + " ','" + txtmail.Text + " ','" + txtkimlik.Text + "','" + txtoda.Text + "','" + richTextBox1.Text + "','" + dtpgiriş.Value.ToString("yyyy-MM-dd") + "','" + dtpçıkış.Value.ToString("yyyy-MM-dd") + "')", baglantı);
            komut.ExecuteNonQuery();//gönderilen  parametre üzerinde değişiklik yapr



            baglantı.Close();
            MessageBox.Show("MÜŞTERİ KAYDI YAPILDI");
        }

        private void yenimüşteri_Load(object sender, EventArgs e)
        {

            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select *from Oda101 ", baglantı);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btnoda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglantı.Close();


            if (btnoda101.Text != "101")
            {
                btnoda101.BackColor = Color.Red;
            }

            //oda 102 için.... 
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select *from Oda102 ", baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btnoda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglantı.Close();


            if (btnoda102.Text != "102")
            {
                btnoda102.BackColor = Color.Red;
            }
            // oda103 için

            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("select *from Oda103 ", baglantı);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                btnoda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglantı.Close();


            if (btnoda103.Text != "103")
            {
                btnoda103.BackColor = Color.Red;
            }
            //oda104 için


            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select *from Oda104 ", baglantı);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                btnoda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglantı.Close();


            if (btnoda104.Text != "104")
            {
                btnoda104.BackColor = Color.Red;
            }
        }
    }
}
