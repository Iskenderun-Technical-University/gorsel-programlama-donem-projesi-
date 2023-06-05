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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otomasyon
{
    public partial class frmmüsteriler : Form
    {
        public frmmüsteriler()
        {
            InitializeComponent();
        }
       
        SqlConnection baglantı = new SqlConnection("Data Source=CRAZYY\\SQLEXPRESS01;Initial Catalog=otamosyon;Integrated Security=True");
        
       private void verilergoster()
        {
            listView1.Items.Clear();    
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from MüsteriEkle", baglantı);
            SqlDataReader oku=komut.ExecuteReader();


            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem(); 
                ekle.Text= oku[" İd"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["ÇıkısTarihi"].ToString());
                 listView1.Items.Add(ekle); 
            }
            baglantı.Close();
        }
        private void frmmüsteriler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtadi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbcinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            msktxttel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtmail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtkimlik.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtoda.Text = listView1.SelectedItems[0].SubItems[7].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpgiriş.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpçıkış.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from MüsteriEkle where [ İd]=(" + id + ")", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            verilergoster();
        
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtadi.Clear();
            txtsoyadi.Clear();
            cmbcinsiyet.Text = "";
            msktxttel.Clear();  
            richTextBox1.Clear();
            txtmail.Text = "";
            txtkimlik.Clear();
            txtoda.Clear();
            dtpgiriş.Text = "";
            dtpçıkış.Text = "";

        }

        private void btnara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from MüsteriEkle where Adi like '%" +richTextBox2.Text +"%'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku[" İd"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["ÇıkısTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglantı.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtadi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtso.Text = listView1.SelectedItems[0].SubItems[2].Text;*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
//Data Source=CRAZYY\SQLEXPRESS01;Initial Catalog=otamosyon;Integrated Security=True