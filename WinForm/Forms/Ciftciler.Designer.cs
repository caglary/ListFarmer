namespace WinForm.Forms
{
    partial class Ciftciler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ciftciler));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTcNo = new WinForm.UserControl.NumberOnly();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnCiftciGuncelleSil = new System.Windows.Forms.Button();
            this.btnYeniCiftciEkle = new System.Windows.Forms.Button();
            this.btnDilekceShow = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lblListeToplam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTcNo);
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.btnCiftciGuncelleSil);
            this.panel1.Controls.Add(this.btnYeniCiftciEkle);
            this.panel1.Controls.Add(this.btnDilekceShow);
            this.panel1.Controls.Add(this.txtIsim);
            this.panel1.Controls.Add(this.lblListeToplam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 145);
            this.panel1.TabIndex = 0;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(12, 35);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(193, 22);
            this.txtTcNo.TabIndex = 0;
            this.txtTcNo.TextChanged += new System.EventHandler(this.TxtTcNo_TextChanged);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.Location = new System.Drawing.Point(963, 34);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 85);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Restore Json";
            this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.Image")));
            this.btnBackup.Location = new System.Drawing.Point(1044, 34);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 85);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup Json";
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // btnCiftciGuncelleSil
            // 
            this.btnCiftciGuncelleSil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCiftciGuncelleSil.Image = ((System.Drawing.Image)(resources.GetObject("btnCiftciGuncelleSil.Image")));
            this.btnCiftciGuncelleSil.Location = new System.Drawing.Point(415, 33);
            this.btnCiftciGuncelleSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCiftciGuncelleSil.Name = "btnCiftciGuncelleSil";
            this.btnCiftciGuncelleSil.Size = new System.Drawing.Size(107, 86);
            this.btnCiftciGuncelleSil.TabIndex = 2;
            this.btnCiftciGuncelleSil.Text = "Çiftçi Güncelle/Sil";
            this.btnCiftciGuncelleSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCiftciGuncelleSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCiftciGuncelleSil.UseVisualStyleBackColor = false;
            this.btnCiftciGuncelleSil.Click += new System.EventHandler(this.BtnCiftciGuncelleSil_Click);
            // 
            // btnYeniCiftciEkle
            // 
            this.btnYeniCiftciEkle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnYeniCiftciEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniCiftciEkle.Image")));
            this.btnYeniCiftciEkle.Location = new System.Drawing.Point(325, 33);
            this.btnYeniCiftciEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYeniCiftciEkle.Name = "btnYeniCiftciEkle";
            this.btnYeniCiftciEkle.Size = new System.Drawing.Size(84, 86);
            this.btnYeniCiftciEkle.TabIndex = 2;
            this.btnYeniCiftciEkle.Text = "Yeni Çiftçi Ekle";
            this.btnYeniCiftciEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnYeniCiftciEkle.UseVisualStyleBackColor = false;
            this.btnYeniCiftciEkle.Click += new System.EventHandler(this.BtnYeniCiftciEkle_Click);
            // 
            // btnDilekceShow
            // 
            this.btnDilekceShow.Image = ((System.Drawing.Image)(resources.GetObject("btnDilekceShow.Image")));
            this.btnDilekceShow.Location = new System.Drawing.Point(235, 33);
            this.btnDilekceShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDilekceShow.Name = "btnDilekceShow";
            this.btnDilekceShow.Size = new System.Drawing.Size(84, 86);
            this.btnDilekceShow.TabIndex = 2;
            this.btnDilekceShow.Text = "Dilekçe Göster";
            this.btnDilekceShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDilekceShow.UseVisualStyleBackColor = true;
            this.btnDilekceShow.Click += new System.EventHandler(this.BtnDilekceShow_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(12, 82);
            this.txtIsim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(193, 22);
            this.txtIsim.TabIndex = 1;
            this.txtIsim.TextChanged += new System.EventHandler(this.TxtIsim_TextChanged);
            // 
            // lblListeToplam
            // 
            this.lblListeToplam.AutoSize = true;
            this.lblListeToplam.Location = new System.Drawing.Point(9, 126);
            this.lblListeToplam.Name = "lblListeToplam";
            this.lblListeToplam.Size = new System.Drawing.Size(59, 17);
            this.lblListeToplam.TabIndex = 0;
            this.lblListeToplam.Text = "Toplam ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "İsim ile arama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc no ile arama";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 145);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 456);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Ciftciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 601);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ciftciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ciftciler";
            this.Load += new System.EventHandler(this.Ciftciler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDilekceShow;
        private System.Windows.Forms.Label lblListeToplam;
        private System.Windows.Forms.Button btnYeniCiftciEkle;
        private System.Windows.Forms.Button btnCiftciGuncelleSil;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private UserControl.NumberOnly txtTcNo;
    }
}