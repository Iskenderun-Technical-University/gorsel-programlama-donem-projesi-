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
using System.Data.Sql;
namespace otomasyon
{
    public partial class giriş : Form
    {
        public giriş()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=CRAZYY\\SQLEXPRESS01;Initial Catalog=otamosyon;Integrated Security=True");



        // HOCAMIZA NOT !! admin giriş kullanici adi=adminotel  şifre=otel12345
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                string sql = "select*from ADMİNGİRİS where Kullanici=@Kullaniciadi AND Sifre=@Sifresi ";
                SqlParameter prm1 = new SqlParameter("KullaniciAdi", textBox1.Text.Trim() );
                SqlParameter prm2 = new SqlParameter("Sifresi ", textBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglantı);
                komut.Parameters.Add(prm1); 
                komut.Parameters.Add(prm2); 


                DataTable dt=new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    frmanaform form = new frmanaform();
                    form.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş ");
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
