namespace WinForm.Forms
{
    partial class CiftciEkle
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
        }
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CiftciEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtKayitTarihi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMahalle = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTcKimlikNoDogrula = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefonNumarasi = new WinForm.UserControl.NumberOnly();
            this.txtDogumYili = new WinForm.UserControl.NumberOnly();
            this.txtTcNumarasi = new WinForm.UserControl.NumberOnly();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "(*) TC Numarası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "(*) İsim :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "(*) Soyisim :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "(*) Mahalle :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kayıt Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Açıklama :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "(*) Doğum Yılı:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(160, 38);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(270, 22);
            this.txtID.TabIndex = 5;
            // 
            // txtIsim
            // 
            this.txtIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtIsim.Location = new System.Drawing.Point(160, 94);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(270, 24);
            this.txtIsim.TabIndex = 7;
            this.txtIsim.Enter += new System.EventHandler(this.txtEnter);
            this.txtIsim.Leave += new System.EventHandler(this.txtLeave);
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSoyisim.Location = new System.Drawing.Point(160, 122);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(270, 24);
            this.txtSoyisim.TabIndex = 8;
            this.txtSoyisim.Enter += new System.EventHandler(this.txtEnter);
            this.txtSoyisim.Leave += new System.EventHandler(this.txtLeave);
            // 
            // txtKayitTarihi
            // 
            this.txtKayitTarihi.Location = new System.Drawing.Point(160, 208);
            this.txtKayitTarihi.Name = "txtKayitTarihi";
            this.txtKayitTarihi.ReadOnly = true;
            this.txtKayitTarihi.Size = new System.Drawing.Size(270, 22);
            this.txtKayitTarihi.TabIndex = 11;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtAciklama.Location = new System.Drawing.Point(160, 236);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(270, 84);
            this.txtAciklama.TabIndex = 12;
            this.txtAciklama.Enter += new System.EventHandler(this.txtEnter);
            this.txtAciklama.Leave += new System.EventHandler(this.txtLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefonNumarasi);
            this.groupBox1.Controls.Add(this.txtDogumYili);
            this.groupBox1.Controls.Add(this.txtTcNumarasi);
            this.groupBox1.Controls.Add(this.txtMahalle);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKayitTarihi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSoyisim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIsim);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boş alanları doldurunuz";
            // 
            // txtMahalle
            // 
            this.txtMahalle.AutoCompleteCustomSource.AddRange(new string[] {
            "ALACALAR",
            "ARMUTLU",
            "BEŞTAM",
            "ÇAKIRLI",
            "ÇUKUR",
            "ESENLİ ",
            "FATİH",
            "HİSARCIK",
            "KARAMANLI",
            "KAYABAŞI",
            "KOYUNCULU",
            "KÜÇÜKYAKA",
            "KUTLULAR",
            "ORTAKÖY",
            "PELİTÖZÜ",
            "SAĞLIK",
            "SARIYAR",
            "SEFALIK",
            "TOYGAR",
            "UZUNDERE",
            "ZAFERİMİLLİ"});
            this.txtMahalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtMahalle.FormattingEnabled = true;
            this.txtMahalle.Items.AddRange(new object[] {
            "ALACALAR",
            "ARMUTLU",
            "BEŞTAM",
            "ÇAKIRLI",
            "ÇUKUR",
            "ESENLİ ",
            "FATİH",
            "HİSARCIK",
            "KARAMANLI",
            "KAYABAŞI",
            "KOYUNCULU",
            "KÜÇÜKYAKA",
            "KUTLULAR",
            "ORTAKÖY",
            "PELİTÖZÜ",
            "SAĞLIK",
            "SARIYAR",
            "SEFALIK",
            "TOYGAR",
            "UZUNDERE",
            "ZAFERİMİLLİ"});
            this.txtMahalle.Location = new System.Drawing.Point(160, 178);
            this.txtMahalle.Name = "txtMahalle";
            this.txtMahalle.Size = new System.Drawing.Size(270, 26);
            this.txtMahalle.TabIndex = 10;
            this.txtMahalle.Text = "mahalle seçiniz";
            // 
            // btnEkle
            // 
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(348, 451);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 46);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // btnTcKimlikNoDogrula
            // 
            this.btnTcKimlikNoDogrula.Image = ((System.Drawing.Image)(resources.GetObject("btnTcKimlikNoDogrula.Image")));
            this.btnTcKimlikNoDogrula.Location = new System.Drawing.Point(12, 452);
            this.btnTcKimlikNoDogrula.Name = "btnTcKimlikNoDogrula";
            this.btnTcKimlikNoDogrula.Size = new System.Drawing.Size(268, 46);
            this.btnTcKimlikNoDogrula.TabIndex = 1;
            this.btnTcKimlikNoDogrula.Text = "TC Kimlik No Doğrula";
            this.btnTcKimlikNoDogrula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTcKimlikNoDogrula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTcKimlikNoDogrula.UseVisualStyleBackColor = true;
            this.btnTcKimlikNoDogrula.Click += new System.EventHandler(this.btnTcKimlikNoDogrula_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(281, 34);
            this.label9.TabIndex = 1;
            this.label9.Text = "Kişiyi eklemeden önce TC Kimlik doğrulama\r\nişlemi yapabilirsiniz.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(333, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "(*) ile işaretlenen alanların doldurulması zorunludur.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Telefon Numarası:";
            // 
            // txtTelefonNumarasi
            // 
            this.txtTelefonNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTelefonNumarasi.Location = new System.Drawing.Point(160, 326);
            this.txtTelefonNumarasi.Name = "txtTelefonNumarasi";
            this.txtTelefonNumarasi.Size = new System.Drawing.Size(208, 24);
            this.txtTelefonNumarasi.TabIndex = 13;
            // 
            // txtDogumYili
            // 
            this.txtDogumYili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDogumYili.Location = new System.Drawing.Point(160, 150);
            this.txtDogumYili.Name = "txtDogumYili";
            this.txtDogumYili.Size = new System.Drawing.Size(78, 24);
            this.txtDogumYili.TabIndex = 9;
            // 
            // txtTcNumarasi
            // 
            this.txtTcNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcNumarasi.Location = new System.Drawing.Point(160, 66);
            this.txtTcNumarasi.Name = "txtTcNumarasi";
            this.txtTcNumarasi.Size = new System.Drawing.Size(270, 24);
            this.txtTcNumarasi.TabIndex = 6;
            // 
            // CiftciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(465, 509);
            this.Controls.Add(this.btnTcKimlikNoDogrula);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.Name = "CiftciEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciftci Bilgi Formu";
            this.Load += new System.EventHandler(this.CiftciBilgiFormu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtKayitTarihi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox txtMahalle;
        private UserControl.NumberOnly txtTcNumarasi;
        private UserControl.NumberOnly txtDogumYili;
        private System.Windows.Forms.Button btnTcKimlikNoDogrula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private UserControl.NumberOnly txtTelefonNumarasi;
        private System.Windows.Forms.Label label11;
    }
}