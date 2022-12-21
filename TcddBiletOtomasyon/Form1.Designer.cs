namespace TcddBiletOtomasyon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

            form1 = null;

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbTam = new System.Windows.Forms.RadioButton();
            this.rbOgrenci = new System.Windows.Forms.RadioButton();
            this.groupBoxbiletturu = new System.Windows.Forms.GroupBox();
            this.groupBoxyön = new System.Windows.Forms.GroupBox();
            this.rbTekyon = new System.Windows.Forms.RadioButton();
            this.rbGidisDonus = new System.Windows.Forms.RadioButton();
            this.btnDevam = new System.Windows.Forms.Button();
            this.groupBoxrezervasyonbilgi = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numYolcuSayisi = new System.Windows.Forms.NumericUpDown();
            this.cbNereye = new System.Windows.Forms.ComboBox();
            this.cbNereden = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTarih = new System.Windows.Forms.GroupBox();
            this.dpDonusTarihi = new System.Windows.Forms.DateTimePicker();
            this.dpGidisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxkisiselbilgi = new System.Windows.Forms.GroupBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxbiletturu.SuspendLayout();
            this.groupBoxyön.SuspendLayout();
            this.groupBoxrezervasyonbilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYolcuSayisi)).BeginInit();
            this.groupBoxTarih.SuspendLayout();
            this.groupBoxkisiselbilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTam
            // 
            this.tbTam.AutoSize = true;
            this.tbTam.Checked = true;
            this.tbTam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbTam.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTam.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbTam.Location = new System.Drawing.Point(28, 41);
            this.tbTam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTam.Name = "tbTam";
            this.tbTam.Size = new System.Drawing.Size(53, 22);
            this.tbTam.TabIndex = 1;
            this.tbTam.TabStop = true;
            this.tbTam.Text = "Tam";
            this.tbTam.UseVisualStyleBackColor = true;
            // 
            // rbOgrenci
            // 
            this.rbOgrenci.AutoSize = true;
            this.rbOgrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbOgrenci.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbOgrenci.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbOgrenci.Location = new System.Drawing.Point(28, 91);
            this.rbOgrenci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbOgrenci.Name = "rbOgrenci";
            this.rbOgrenci.Size = new System.Drawing.Size(85, 22);
            this.rbOgrenci.TabIndex = 2;
            this.rbOgrenci.Text = "Öğrenci";
            this.rbOgrenci.UseVisualStyleBackColor = true;
            // 
            // groupBoxbiletturu
            // 
            this.groupBoxbiletturu.BackColor = System.Drawing.Color.Black;
            this.groupBoxbiletturu.Controls.Add(this.rbOgrenci);
            this.groupBoxbiletturu.Controls.Add(this.tbTam);
            this.groupBoxbiletturu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxbiletturu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(208)))), ((int)(((byte)(18)))), ((int)(((byte)(6)))));
            this.groupBoxbiletturu.Location = new System.Drawing.Point(32, 9);
            this.groupBoxbiletturu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxbiletturu.Name = "groupBoxbiletturu";
            this.groupBoxbiletturu.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxbiletturu.Size = new System.Drawing.Size(204, 162);
            this.groupBoxbiletturu.TabIndex = 4;
            this.groupBoxbiletturu.TabStop = false;
            this.groupBoxbiletturu.Text = "Bilet Türü";
            // 
            // groupBoxyön
            // 
            this.groupBoxyön.BackColor = System.Drawing.Color.Black;
            this.groupBoxyön.Controls.Add(this.rbTekyon);
            this.groupBoxyön.Controls.Add(this.rbGidisDonus);
            this.groupBoxyön.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxyön.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(208)))), ((int)(((byte)(18)))), ((int)(((byte)(6)))));
            this.groupBoxyön.Location = new System.Drawing.Point(251, 6);
            this.groupBoxyön.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxyön.Name = "groupBoxyön";
            this.groupBoxyön.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxyön.Size = new System.Drawing.Size(204, 168);
            this.groupBoxyön.TabIndex = 5;
            this.groupBoxyön.TabStop = false;
            this.groupBoxyön.Text = "Yön";
            // 
            // rbTekyon
            // 
            this.rbTekyon.AutoSize = true;
            this.rbTekyon.Checked = true;
            this.rbTekyon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTekyon.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbTekyon.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbTekyon.Location = new System.Drawing.Point(31, 46);
            this.rbTekyon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTekyon.Name = "rbTekyon";
            this.rbTekyon.Size = new System.Drawing.Size(85, 22);
            this.rbTekyon.TabIndex = 2;
            this.rbTekyon.TabStop = true;
            this.rbTekyon.Tag = "";
            this.rbTekyon.Text = "Tek Yön";
            this.rbTekyon.UseVisualStyleBackColor = true;
            this.rbTekyon.CheckedChanged += new System.EventHandler(this.tyRadio_CheckedChanged);
            // 
            // rbGidisDonus
            // 
            this.rbGidisDonus.AutoSize = true;
            this.rbGidisDonus.BackColor = System.Drawing.Color.Transparent;
            this.rbGidisDonus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbGidisDonus.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbGidisDonus.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbGidisDonus.Location = new System.Drawing.Point(31, 98);
            this.rbGidisDonus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbGidisDonus.Name = "rbGidisDonus";
            this.rbGidisDonus.Size = new System.Drawing.Size(117, 22);
            this.rbGidisDonus.TabIndex = 1;
            this.rbGidisDonus.Text = "Gidiş-Dönüş";
            this.rbGidisDonus.UseVisualStyleBackColor = false;
            this.rbGidisDonus.CheckedChanged += new System.EventHandler(this.gdRadio_CheckedChanged);
            // 
            // btnDevam
            // 
            this.btnDevam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.btnDevam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevam.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDevam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(208)))), ((int)(((byte)(18)))), ((int)(((byte)(6)))));
            this.btnDevam.Location = new System.Drawing.Point(124, 249);
            this.btnDevam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(163, 61);
            this.btnDevam.TabIndex = 6;
            this.btnDevam.Text = "Devam";
            this.btnDevam.UseVisualStyleBackColor = false;
            this.btnDevam.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxrezervasyonbilgi
            // 
            this.groupBoxrezervasyonbilgi.BackColor = System.Drawing.Color.Black;
            this.groupBoxrezervasyonbilgi.Controls.Add(this.label3);
            this.groupBoxrezervasyonbilgi.Controls.Add(this.numYolcuSayisi);
            this.groupBoxrezervasyonbilgi.Controls.Add(this.cbNereye);
            this.groupBoxrezervasyonbilgi.Controls.Add(this.cbNereden);
            this.groupBoxrezervasyonbilgi.Controls.Add(this.label2);
            this.groupBoxrezervasyonbilgi.Controls.Add(this.label1);
            this.groupBoxrezervasyonbilgi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxrezervasyonbilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(208)))), ((int)(((byte)(18)))), ((int)(((byte)(6)))));
            this.groupBoxrezervasyonbilgi.Location = new System.Drawing.Point(463, 138);
            this.groupBoxrezervasyonbilgi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxrezervasyonbilgi.Name = "groupBoxrezervasyonbilgi";
            this.groupBoxrezervasyonbilgi.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxrezervasyonbilgi.Size = new System.Drawing.Size(376, 209);
            this.groupBoxrezervasyonbilgi.TabIndex = 5;
            this.groupBoxrezervasyonbilgi.TabStop = false;
            this.groupBoxrezervasyonbilgi.Text = "Rezervasyon bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(13, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yolcu Sayısı  :";
            // 
            // numYolcuSayisi
            // 
            this.numYolcuSayisi.BackColor = System.Drawing.Color.White;
            this.numYolcuSayisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numYolcuSayisi.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numYolcuSayisi.ForeColor = System.Drawing.Color.Black;
            this.numYolcuSayisi.Location = new System.Drawing.Point(164, 155);
            this.numYolcuSayisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numYolcuSayisi.Name = "numYolcuSayisi";
            this.numYolcuSayisi.Size = new System.Drawing.Size(81, 25);
            this.numYolcuSayisi.TabIndex = 4;
            this.numYolcuSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbNereye
            // 
            this.cbNereye.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNereye.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNereye.BackColor = System.Drawing.Color.White;
            this.cbNereye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNereye.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNereye.FormattingEnabled = true;
            this.cbNereye.Items.AddRange(new object[] {
            "Ankara",
            "izmir",
            "istanbul"});
            this.cbNereye.Location = new System.Drawing.Point(164, 98);
            this.cbNereye.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNereye.Name = "cbNereye";
            this.cbNereye.Size = new System.Drawing.Size(165, 26);
            this.cbNereye.TabIndex = 3;
            // 
            // cbNereden
            // 
            this.cbNereden.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNereden.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNereden.BackColor = System.Drawing.Color.White;
            this.cbNereden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNereden.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNereden.FormattingEnabled = true;
            this.cbNereden.Items.AddRange(new object[] {
            "Ankara",
            "izmir",
            "istanbul"});
            this.cbNereden.Location = new System.Drawing.Point(164, 48);
            this.cbNereden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNereden.Name = "cbNereden";
            this.cbNereden.Size = new System.Drawing.Size(165, 26);
            this.cbNereden.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nereye        :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nereden       :";
            // 
            // groupBoxTarih
            // 
            this.groupBoxTarih.BackColor = System.Drawing.Color.Black;
            this.groupBoxTarih.Controls.Add(this.dpDonusTarihi);
            this.groupBoxTarih.Controls.Add(this.dpGidisTarihi);
            this.groupBoxTarih.Controls.Add(this.label4);
            this.groupBoxTarih.Controls.Add(this.label5);
            this.groupBoxTarih.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(208)))), ((int)(((byte)(18)))), ((int)(((byte)(6)))));
            this.groupBoxTarih.Location = new System.Drawing.Point(32, 178);
            this.groupBoxTarih.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTarih.Name = "groupBoxTarih";
            this.groupBoxTarih.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTarih.Size = new System.Drawing.Size(423, 169);
            this.groupBoxTarih.TabIndex = 6;
            this.groupBoxTarih.TabStop = false;
            this.groupBoxTarih.Text = "Tarih";
            // 
            // dpDonusTarihi
            // 
            this.dpDonusTarihi.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dpDonusTarihi.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(1)))), ((int)(((byte)(2)))));
            this.dpDonusTarihi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dpDonusTarihi.Enabled = false;
            this.dpDonusTarihi.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpDonusTarihi.Location = new System.Drawing.Point(141, 111);
            this.dpDonusTarihi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpDonusTarihi.MinDate = new System.DateTime(2022, 12, 8, 0, 0, 0, 0);
            this.dpDonusTarihi.Name = "dpDonusTarihi";
            this.dpDonusTarihi.Size = new System.Drawing.Size(265, 25);
            this.dpDonusTarihi.TabIndex = 7;
            this.dpDonusTarihi.Value = new System.DateTime(2022, 12, 8, 0, 0, 0, 0);
            // 
            // dpGidisTarihi
            // 
            this.dpGidisTarihi.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dpGidisTarihi.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(132)))));
            this.dpGidisTarihi.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(1)))), ((int)(((byte)(2)))));
            this.dpGidisTarihi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dpGidisTarihi.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpGidisTarihi.Location = new System.Drawing.Point(141, 52);
            this.dpGidisTarihi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpGidisTarihi.MinDate = new System.DateTime(2022, 12, 2, 0, 0, 0, 0);
            this.dpGidisTarihi.Name = "dpGidisTarihi";
            this.dpGidisTarihi.Size = new System.Drawing.Size(265, 25);
            this.dpGidisTarihi.TabIndex = 6;
            this.dpGidisTarihi.Value = new System.DateTime(2022, 12, 2, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(4, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dönüş Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(4, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gidiş Tarihi :";
            // 
            // groupBoxkisiselbilgi
            // 
            this.groupBoxkisiselbilgi.BackColor = System.Drawing.Color.Black;
            this.groupBoxkisiselbilgi.Controls.Add(this.txtSoyad);
            this.groupBoxkisiselbilgi.Controls.Add(this.btnDevam);
            this.groupBoxkisiselbilgi.Controls.Add(this.txtTc);
            this.groupBoxkisiselbilgi.Controls.Add(this.txtAd);
            this.groupBoxkisiselbilgi.Controls.Add(this.label7);
            this.groupBoxkisiselbilgi.Controls.Add(this.label8);
            this.groupBoxkisiselbilgi.Controls.Add(this.txtEmail);
            this.groupBoxkisiselbilgi.Controls.Add(this.label6);
            this.groupBoxkisiselbilgi.Controls.Add(this.label9);
            this.groupBoxkisiselbilgi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxkisiselbilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(208)))), ((int)(((byte)(18)))), ((int)(((byte)(6)))));
            this.groupBoxkisiselbilgi.Location = new System.Drawing.Point(847, 6);
            this.groupBoxkisiselbilgi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxkisiselbilgi.Name = "groupBoxkisiselbilgi";
            this.groupBoxkisiselbilgi.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxkisiselbilgi.Size = new System.Drawing.Size(312, 341);
            this.groupBoxkisiselbilgi.TabIndex = 7;
            this.groupBoxkisiselbilgi.TabStop = false;
            this.groupBoxkisiselbilgi.Text = "Kişisel bilgiler";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSoyad.Location = new System.Drawing.Point(124, 88);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(161, 25);
            this.txtSoyad.TabIndex = 11;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTc.Location = new System.Drawing.Point(124, 186);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(161, 25);
            this.txtTc.TabIndex = 14;
            this.txtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAd.Location = new System.Drawing.Point(124, 39);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(161, 25);
            this.txtAd.TabIndex = 10;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(28, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Soyad  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(28, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "E-Mail :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(124, 138);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 25);
            this.txtEmail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(28, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ad     :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(28, 191);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "TC     :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(9, 359);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1016, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "  * Tam Bilet Fiyatı: 200 TL/ Öğrenci Bilet Fiyatı: 180 TL/ Bir yolcu Gidiş-Dönüş" +
    " yolculuk için tek yönün iki katı fiyat öder.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(9, 382);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(984, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = " ** Her gün saat 12:00\'de Tüm kalkış noktalarından varış noktalarına seferler var" +
    "dır. Her yolcu için sefer fiyatı eklenir.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(9, 408);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(680, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "*** Her bilet alımınızda toplam bilet tutarının %10\'u kadar bonus puan kazanırsın" +
    "ız.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1175, 441);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxkisiselbilgi);
            this.Controls.Add(this.groupBoxTarih);
            this.Controls.Add(this.groupBoxrezervasyonbilgi);
            this.Controls.Add(this.groupBoxyön);
            this.Controls.Add(this.groupBoxbiletturu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCDD - Bilet Rezervasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxbiletturu.ResumeLayout(false);
            this.groupBoxbiletturu.PerformLayout();
            this.groupBoxyön.ResumeLayout(false);
            this.groupBoxyön.PerformLayout();
            this.groupBoxrezervasyonbilgi.ResumeLayout(false);
            this.groupBoxrezervasyonbilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYolcuSayisi)).EndInit();
            this.groupBoxTarih.ResumeLayout(false);
            this.groupBoxTarih.PerformLayout();
            this.groupBoxkisiselbilgi.ResumeLayout(false);
            this.groupBoxkisiselbilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton tbTam;
        private System.Windows.Forms.RadioButton rbOgrenci;
        private System.Windows.Forms.GroupBox groupBoxbiletturu;
        private System.Windows.Forms.GroupBox groupBoxyön;
        private System.Windows.Forms.RadioButton rbTekyon;
        private System.Windows.Forms.RadioButton rbGidisDonus;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.GroupBox groupBoxrezervasyonbilgi;
        private System.Windows.Forms.ComboBox cbNereden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numYolcuSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxTarih;
        private System.Windows.Forms.DateTimePicker dpGidisTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpDonusTarihi;
        private System.Windows.Forms.ComboBox cbNereye;
        private System.Windows.Forms.GroupBox groupBoxkisiselbilgi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

