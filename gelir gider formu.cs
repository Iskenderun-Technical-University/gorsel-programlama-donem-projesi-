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
    public partial class gelir_gider_formu : Form
    {
        public gelir_gider_formu()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=CRAZYY\\SQLEXPRESS01;Initial Catalog=otamosyon;Integrated Security=True");
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int personel;
            if (int.TryParse(textBox1.Text, out personel))
            {
                lblpersonelmaas.Text = (personel * 1500).ToString();
            }
            else
            {
                // Display an error message or take other appropriate action


            }
            int sonuc;
            sonuc = Convert.ToInt32(lblkasatoplam.Text) - (Convert.ToInt16(lblpersonelmaas.Text) + Convert.ToInt16(lblalınanürün1.Text) + Convert.ToInt16(lblalınanürün2.Text) +Convert.ToInt16(lblalınanürün3.Text)+ Convert.ToInt16(lblfaturalar1.Text)+ Convert.ToInt16(lblfaturalar2.Text)+Convert.ToInt16(lblfaturalar3.Text));
             lblsonuc.Text = sonuc.ToString();  
        
        
        }

            private void gelir_gider_formu_Load(object sender, EventArgs e)
        {

            // kasada ki toplam tutar

            baglantı.Open();
            SqlCommand komut = new SqlCommand("select sum(Ücret) as toplam from MüsteriEkle ", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblkasatoplam.Text = oku["toplam"].ToString();
            }
            baglantı.Close();

            // Gıdalar

            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Gıda) as toplam1 from Stok ", baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblalınanürün1.Text = oku2["toplam1"].ToString();
            }
            baglantı.Close();

            // içecekler

            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("select sum(İçecek) as toplam2 from Stok ", baglantı);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblalınanürün2.Text = oku3["toplam2"].ToString();
            }
            baglantı.Close();


            // cerezler 
            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Cerezler) as toplam3 from Stok ", baglantı);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblalınanürün3.Text = oku4["toplam3"].ToString();
            }
            baglantı.Close();

            //elektrirk
            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Elektrik ) as toplam4 from Faturalar ", baglantı);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblfaturalar1.Text = oku5["toplam4"].ToString();
            }
            baglantı.Close();


            //su
            baglantı.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Su ) as toplam5 from Faturalar", baglantı);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
               lblfaturalar2.Text = oku6["toplam5"].ToString();
            }
            baglantı.Close();



            //İnternet
            baglantı.Open();
            SqlCommand komut7 = new SqlCommand("select sum(İnternet ) as toplam6 from Faturalar", baglantı);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblfaturalar3.Text = oku7["toplam6"].ToString();
            }
            baglantı.Close();



            }













            /*int personel;
            personel = Convert.ToInt16(textBox1.Text);
            lblpersonelmaas.Text=(personel*1500).ToString();*/



        }
    }

