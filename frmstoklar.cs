using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace otomasyon
{
    public partial class frmstoklar : Form
    {
        public frmstoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=CRAZYY\\SQLEXPRESS01;Initial Catalog=otamosyon;Integrated Security=True");
        
        private void veriler()

        {
            listView1.Items.Clear();   
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from Stok  ", baglantı);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem ekle=new ListViewItem();
                ekle.Text = rdr["Gıda"].ToString();
                ekle.SubItems.Add(rdr["İçecek"].ToString());
                ekle.SubItems.Add(rdr["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglantı.Close();

        }

         private void veriler2()
        {
            listView2.Items.Clear();
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select *from Faturalar   ", baglantı);
            SqlDataReader rdr2 = komut2.ExecuteReader();
            while (rdr2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rdr2["Elektrik"].ToString();
                ekle.SubItems.Add(rdr2["Su"].ToString());
                ekle.SubItems.Add(rdr2["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            baglantı.Close();





        }


        private void btnkaydet_Click(object sender, EventArgs e)
        {

            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Stok (Gıda, İçecek, Cerezler) values ('" + txtgidalar.Text + "','" + txtiçecek.Text + "','" + txtatıştırmaliklar.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            veriler();



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmstoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           /* e.Graphics.Clear(Color.Transparent); // arka planı saydam yap
            e.Graphics.DrawString(groupBox1.Text, groupBox1.Font, Brushes.Black, 0, 0); // kontrolün metnini çiz*/
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("insert into Faturalar  (Elektrik,Su,İnternet ) values ('" + txtelektrik.Text + "','" + txtsu.Text + "','" + txtinternet.Text + "')", baglantı);
            komut2.ExecuteNonQuery();
            baglantı.Close();
            veriler2();

        }
    }
}
