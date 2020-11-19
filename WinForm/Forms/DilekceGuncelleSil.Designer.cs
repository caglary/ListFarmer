namespace WinForm.Forms
{
    partial class DilekceGuncelleSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DilekceGuncelleSil));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.lblDilekceId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUretimYili = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDilekceKabulTarihi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDilekceTarihi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIlceAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIlAdi = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDilekceNumarasi = new WinForm.UserControl.NumberOnly();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txtDilekceNumarasi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbDurum);
            this.groupBox1.Controls.Add(this.lblDilekceId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbUretimYili);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDilekceKabulTarihi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDilekceTarihi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIlceAdi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIlAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dilekce Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Durum :";
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Aktif",
            "Pasif",
            "Bilinmiyor"});
            this.cmbDurum.Location = new System.Drawing.Point(178, 277);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(170, 24);
            this.cmbDurum.TabIndex = 6;
            // 
            // lblDilekceId
            // 
            this.lblDilekceId.AutoSize = true;
            this.lblDilekceId.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDilekceId.Location = new System.Drawing.Point(15, 33);
            this.lblDilekceId.Name = "lblDilekceId";
            this.lblDilekceId.Size = new System.Drawing.Size(71, 17);
            this.lblDilekceId.TabIndex = 0;
            this.lblDilekceId.Text = "Dilekce ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dilekce Numarası :";
            // 
            // cmbUretimYili
            // 
            this.cmbUretimYili.Enabled = false;
            this.cmbUretimYili.FormattingEnabled = true;
            this.cmbUretimYili.Items.AddRange(new object[] {
            "2019",
            "2020"});
            this.cmbUretimYili.Location = new System.Drawing.Point(178, 105);
            this.cmbUretimYili.Name = "cmbUretimYili";
            this.cmbUretimYili.Size = new System.Drawing.Size(170, 24);
            this.cmbUretimYili.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Üretim Yılı :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "İl Adı :";
            // 
            // txtDilekceKabulTarihi
            // 
            this.txtDilekceKabulTarihi.Location = new System.Drawing.Point(178, 242);
            this.txtDilekceKabulTarihi.Name = "txtDilekceKabulTarihi";
            this.txtDilekceKabulTarihi.Size = new System.Drawing.Size(149, 22);
            this.txtDilekceKabulTarihi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "İlçe Adı :";
            // 
            // txtDilekceTarihi
            // 
            this.txtDilekceTarihi.Location = new System.Drawing.Point(178, 207);
            this.txtDilekceTarihi.Name = "txtDilekceTarihi";
            this.txtDilekceTarihi.Size = new System.Drawing.Size(149, 22);
            this.txtDilekceTarihi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dilekçe Tarihi :";
            // 
            // txtIlceAdi
            // 
            this.txtIlceAdi.Location = new System.Drawing.Point(178, 172);
            this.txtIlceAdi.Name = "txtIlceAdi";
            this.txtIlceAdi.Size = new System.Drawing.Size(149, 22);
            this.txtIlceAdi.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dilekçe Kabul Tarihi :";
            // 
            // txtIlAdi
            // 
            this.txtIlAdi.Location = new System.Drawing.Point(178, 137);
            this.txtIlAdi.Name = "txtIlAdi";
            this.txtIlAdi.Size = new System.Drawing.Size(149, 22);
            this.txtIlAdi.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(251, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "İptal";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(131, 365);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 50);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(11, 365);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 50);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDilekceNumarasi
            // 
            this.txtDilekceNumarasi.Location = new System.Drawing.Point(178, 67);
            this.txtDilekceNumarasi.Name = "txtDilekceNumarasi";
            this.txtDilekceNumarasi.Size = new System.Drawing.Size(170, 22);
            this.txtDilekceNumarasi.TabIndex = 0;
            // 
            // DilekceGuncelleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 445);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DilekceGuncelleSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DilekceGuncelleSil";
            this.Load += new System.EventHandler(this.DilekceGuncelleSil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUretimYili;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDilekceKabulTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDilekceTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIlceAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIlAdi;
        private System.Windows.Forms.Label lblDilekceId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private UserControl.NumberOnly txtDilekceNumarasi;
    }
}