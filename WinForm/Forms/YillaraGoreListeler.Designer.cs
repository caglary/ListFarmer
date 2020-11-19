namespace WinForm.Forms
{
    partial class YillaraGoreListeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YillaraGoreListeler));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.btn2020 = new System.Windows.Forms.Button();
            this.btn2014 = new System.Windows.Forms.Button();
            this.btn2019 = new System.Windows.Forms.Button();
            this.btn2015 = new System.Windows.Forms.Button();
            this.btn2018 = new System.Windows.Forms.Button();
            this.btn2016 = new System.Windows.Forms.Button();
            this.btn2017 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgwListeler = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTcNo = new WinForm.UserControl.NumberOnly();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.labelToplamKisiSayisi = new System.Windows.Forms.Label();
            this.btnToExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeler)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblBaslik);
            this.panelTop.Controls.Add(this.groupBoxMenu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1397, 100);
            this.panelTop.TabIndex = 1;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.Location = new System.Drawing.Point(672, 42);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(108, 41);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "label6";
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.btn2020);
            this.groupBoxMenu.Controls.Add(this.btn2014);
            this.groupBoxMenu.Controls.Add(this.btn2019);
            this.groupBoxMenu.Controls.Add(this.btn2015);
            this.groupBoxMenu.Controls.Add(this.btn2018);
            this.groupBoxMenu.Controls.Add(this.btn2016);
            this.groupBoxMenu.Controls.Add(this.btn2017);
            this.groupBoxMenu.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(587, 82);
            this.groupBoxMenu.TabIndex = 1;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Görüntülemek istediğiniz yılı seçiniz";
            // 
            // btn2020
            // 
            this.btn2020.Location = new System.Drawing.Point(6, 21);
            this.btn2020.Name = "btn2020";
            this.btn2020.Size = new System.Drawing.Size(75, 46);
            this.btn2020.TabIndex = 0;
            this.btn2020.Text = "2020";
            this.btn2020.UseVisualStyleBackColor = true;
            this.btn2020.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2014
            // 
            this.btn2014.Location = new System.Drawing.Point(492, 21);
            this.btn2014.Name = "btn2014";
            this.btn2014.Size = new System.Drawing.Size(75, 46);
            this.btn2014.TabIndex = 0;
            this.btn2014.Text = "2014";
            this.btn2014.UseVisualStyleBackColor = true;
            this.btn2014.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2019
            // 
            this.btn2019.Location = new System.Drawing.Point(87, 21);
            this.btn2019.Name = "btn2019";
            this.btn2019.Size = new System.Drawing.Size(75, 46);
            this.btn2019.TabIndex = 0;
            this.btn2019.Text = "2019";
            this.btn2019.UseVisualStyleBackColor = true;
            this.btn2019.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2015
            // 
            this.btn2015.Location = new System.Drawing.Point(411, 21);
            this.btn2015.Name = "btn2015";
            this.btn2015.Size = new System.Drawing.Size(75, 46);
            this.btn2015.TabIndex = 0;
            this.btn2015.Text = "2015";
            this.btn2015.UseVisualStyleBackColor = true;
            this.btn2015.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2018
            // 
            this.btn2018.Location = new System.Drawing.Point(168, 21);
            this.btn2018.Name = "btn2018";
            this.btn2018.Size = new System.Drawing.Size(75, 46);
            this.btn2018.TabIndex = 0;
            this.btn2018.Text = "2018";
            this.btn2018.UseVisualStyleBackColor = true;
            this.btn2018.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2016
            // 
            this.btn2016.Location = new System.Drawing.Point(330, 21);
            this.btn2016.Name = "btn2016";
            this.btn2016.Size = new System.Drawing.Size(75, 46);
            this.btn2016.TabIndex = 0;
            this.btn2016.Text = "2016";
            this.btn2016.UseVisualStyleBackColor = true;
            this.btn2016.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2017
            // 
            this.btn2017.Location = new System.Drawing.Point(249, 21);
            this.btn2017.Name = "btn2017";
            this.btn2017.Size = new System.Drawing.Size(75, 46);
            this.btn2017.TabIndex = 0;
            this.btn2017.Text = "2017";
            this.btn2017.UseVisualStyleBackColor = true;
            this.btn2017.Click += new System.EventHandler(this.btn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgwListeler);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.btnBackup);
            this.splitContainer1.Panel2.Controls.Add(this.labelToplamKisiSayisi);
            this.splitContainer1.Panel2.Controls.Add(this.btnToExcel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1397, 494);
            this.splitContainer1.SplitterDistance = 1021;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgwListeler
            // 
            this.dgwListeler.AllowUserToAddRows = false;
            this.dgwListeler.AllowUserToDeleteRows = false;
            this.dgwListeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwListeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwListeler.Location = new System.Drawing.Point(0, 0);
            this.dgwListeler.MultiSelect = false;
            this.dgwListeler.Name = "dgwListeler";
            this.dgwListeler.ReadOnly = true;
            this.dgwListeler.RowHeadersWidth = 51;
            this.dgwListeler.RowTemplate.Height = 24;
            this.dgwListeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwListeler.Size = new System.Drawing.Size(1021, 494);
            this.dgwListeler.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTcNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIsim);
            this.panel1.Location = new System.Drawing.Point(3, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 165);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aramak istediğiniz ismi yazınız";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcNo.Location = new System.Drawing.Point(7, 122);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(254, 30);
            this.txtTcNo.TabIndex = 6;
            this.txtTcNo.TextChanged += new System.EventHandler(this.txtTcNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aramak istediğiniz \r\nTC Kimlik Numarasını yazınız";
            // 
            // txtIsim
            // 
            this.txtIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsim.Location = new System.Drawing.Point(7, 36);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(251, 30);
            this.txtIsim.TabIndex = 5;
            this.txtIsim.TextChanged += new System.EventHandler(this.txtIsim_TextChanged);
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.Image")));
            this.btnBackup.Location = new System.Drawing.Point(285, 398);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 85);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Backup Json";
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // labelToplamKisiSayisi
            // 
            this.labelToplamKisiSayisi.AutoSize = true;
            this.labelToplamKisiSayisi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToplamKisiSayisi.Location = new System.Drawing.Point(194, 27);
            this.labelToplamKisiSayisi.Name = "labelToplamKisiSayisi";
            this.labelToplamKisiSayisi.Size = new System.Drawing.Size(21, 23);
            this.labelToplamKisiSayisi.TabIndex = 0;
            this.labelToplamKisiSayisi.Text = "0";
            // 
            // btnToExcel
            // 
            this.btnToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnToExcel.Image")));
            this.btnToExcel.Location = new System.Drawing.Point(198, 398);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(81, 84);
            this.btnToExcel.TabIndex = 3;
            this.btnToExcel.Text = "To Excel";
            this.btnToExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnToExcel.UseVisualStyleBackColor = true;
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Kişi Sayısı:";
            // 
            // YillaraGoreListeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1397, 594);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelTop);
            this.Name = "YillaraGoreListeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ciftci Dosya Numaraları";
            this.Load += new System.EventHandler(this.YillaraGoreListeler_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.groupBoxMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btn2014;
        private System.Windows.Forms.Button btn2015;
        private System.Windows.Forms.Button btn2016;
        private System.Windows.Forms.Button btn2017;
        private System.Windows.Forms.Button btn2018;
        private System.Windows.Forms.Button btn2019;
        private System.Windows.Forms.Button btn2020;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgwListeler;
        private System.Windows.Forms.Label labelToplamKisiSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnToExcel;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label2;
        private UserControl.NumberOnly txtTcNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}