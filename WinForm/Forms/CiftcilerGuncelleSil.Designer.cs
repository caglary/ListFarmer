namespace WinForm.Forms
{
    partial class CiftcilerGuncelleSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CiftcilerGuncelleSil));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMahalle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKayitTarihi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTcNumarasi = new WinForm.UserControl.NumberOnly();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTcNumarasi);
            this.groupBox1.Controls.Add(this.txtMahalle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKayitTarihi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSoyisim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIsim);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 394);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncellemek istediğiniz alanları değiştiriniz.";
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
            this.txtMahalle.Location = new System.Drawing.Point(158, 177);
            this.txtMahalle.Name = "txtMahalle";
            this.txtMahalle.Size = new System.Drawing.Size(344, 24);
            this.txtMahalle.TabIndex = 8;
            this.txtMahalle.Text = "mahalle seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(158, 347);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(344, 22);
            this.txtTelefon.TabIndex = 7;
            this.txtTelefon.Enter += new System.EventHandler(this.txtEnter);
            this.txtTelefon.Leave += new System.EventHandler(this.txtLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Numarası :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(158, 251);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(344, 84);
            this.txtAciklama.TabIndex = 6;
            this.txtAciklama.Enter += new System.EventHandler(this.txtEnter);
            this.txtAciklama.Leave += new System.EventHandler(this.txtLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mahalle :";
            // 
            // txtKayitTarihi
            // 
            this.txtKayitTarihi.Location = new System.Drawing.Point(158, 214);
            this.txtKayitTarihi.Name = "txtKayitTarihi";
            this.txtKayitTarihi.ReadOnly = true;
            this.txtKayitTarihi.Size = new System.Drawing.Size(344, 22);
            this.txtKayitTarihi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "İsim :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kayıt Tarihi :";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(158, 140);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(344, 22);
            this.txtSoyisim.TabIndex = 3;
            this.txtSoyisim.Enter += new System.EventHandler(this.txtEnter);
            this.txtSoyisim.Leave += new System.EventHandler(this.txtLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Soyisim :";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(158, 103);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(344, 22);
            this.txtIsim.TabIndex = 2;
            this.txtIsim.Enter += new System.EventHandler(this.txtEnter);
            this.txtIsim.Leave += new System.EventHandler(this.txtLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Açıklama :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Telefon :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(158, 29);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(344, 22);
            this.txtID.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(145, 427);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 50);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(275, 427);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 50);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(405, 427);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 50);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "İptal";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // txtTcNumarasi
            // 
            this.txtTcNumarasi.Location = new System.Drawing.Point(158, 66);
            this.txtTcNumarasi.Name = "txtTcNumarasi";
            this.txtTcNumarasi.Size = new System.Drawing.Size(344, 22);
            this.txtTcNumarasi.TabIndex = 1;
            // 
            // CiftcilerGuncelleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(546, 492);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "CiftcilerGuncelleSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Çiftçi Bilgileri ";
            this.Load += new System.EventHandler(this.CiftcilerGuncelleSil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKayitTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox txtMahalle;
        private UserControl.NumberOnly txtTcNumarasi;
    }
}