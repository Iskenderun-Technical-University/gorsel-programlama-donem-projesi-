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
    public partial class Frmodalar1 : Form
    {
        public Frmodalar1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=CRAZYY\\SQLEXPRESS01;Initial Catalog=otamosyon;Integrated Security=True");
        private void Frmodalar1_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select *from Oda101 ", baglantı);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                button3.Text = oku1["Adi"].ToString()+" "+oku1["Soyadi"].ToString();
            }
            baglantı.Close();


            if (button3.Text != "101")
            {
                button3.BackColor = Color.Red;
            }

            //oda 102 için.... 
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select *from Oda102 ", baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                button2.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglantı.Close();


            if (button2.Text != "102")
            {
                button2.BackColor = Color.Red;
            }
            // oda103 için

            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("select *from Oda103 ", baglantı);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                button1.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglantı.Close();


            if (button1.Text != "103")
            {
                button1.BackColor = Color.Red;
            }
            //oda104 için


            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select *from Oda104 ", baglantı);
            SqlDataReader oku4   = komut4.ExecuteReader();

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
              
         
            
    

