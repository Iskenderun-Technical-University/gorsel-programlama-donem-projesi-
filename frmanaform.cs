using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class frmanaform : Form
    {
        public frmanaform()
        {
            InitializeComponent();
        }

     

        private void frmyenimüsteri_Click(object sender, EventArgs e)
        {
            yenimüşteri fr = new yenimüşteri();
            fr.Show();

        }

        private void frmodalar_Click(object sender, EventArgs e)
        {
            Frmodalar1 frmodalar1 = new Frmodalar1();
            frmodalar1.Show();
        }

        private void btnadmingiriş_Click(object sender, EventArgs e)
        {
            giriş fr = new giriş();
            fr.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmmüsteriler fr=new frmmüsteriler();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           /* Button button6 = new Button();
            button6.Width = button6.Height = 50;
            button6.BackColor = Color.Red;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, button6.Width, button6.Height);
            button6.Region = new System.Drawing.Region(path);*/




            MessageBox.Show("Deniz Yıldızı Pansiyon / 2022-Antalya");
           



        }

        private void button2_Click(object sender, EventArgs e)
        {
            gelir_gider_formu fr=new gelir_gider_formu();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmstoklar fr=new frmstoklar(); 
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmradyo fr=new Frmradyo();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*Gazeteler gazeteler=new Gazeteler();
            gazeteler.Show();   */

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Gazeteler gz = new Gazeteler();
            gz.Show();  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
               
            

         
        }

        private void frmanaform_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Deniz Yıldızı Pansiyon / 2022-Antalya");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
          /*  pictureBox1.BackColor = Color.Transparent;*/

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mesajlar ms = new Mesajlar();
            ms.Show();
        }
    }
}
