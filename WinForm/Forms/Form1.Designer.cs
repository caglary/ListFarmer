namespace WinForm
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
        }
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelsol = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFks = new System.Windows.Forms.Button();
            this.btnListeler = new System.Windows.Forms.Button();
            this.btnCiftciler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConnectionStringInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKarsılama = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDatetime = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelsol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelsol
            // 
            this.panelsol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelsol.Controls.Add(this.pictureBox1);
            this.panelsol.Controls.Add(this.btnFks);
            this.panelsol.Controls.Add(this.btnListeler);
            this.panelsol.Controls.Add(this.btnCiftciler);
            this.panelsol.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelsol.Location = new System.Drawing.Point(0, 0);
            this.panelsol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelsol.Name = "panelsol";
            this.panelsol.Size = new System.Drawing.Size(213, 682);
            this.panelsol.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnFks
            // 
            this.btnFks.BackColor = System.Drawing.Color.Tan;
            this.btnFks.FlatAppearance.BorderSize = 0;
            this.btnFks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFks.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFks.Image = ((System.Drawing.Image)(resources.GetObject("btnFks.Image")));
            this.btnFks.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFks.Location = new System.Drawing.Point(-7, 338);
            this.btnFks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFks.Name = "btnFks";
            this.btnFks.Size = new System.Drawing.Size(220, 75);
            this.btnFks.TabIndex = 0;
            this.btnFks.Text = "FKS-MGD";
            this.btnFks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFks.UseVisualStyleBackColor = false;
            this.btnFks.Click += new System.EventHandler(this.btnFks_Click);
            // 
            // btnListeler
            // 
            this.btnListeler.BackColor = System.Drawing.Color.Tan;
            this.btnListeler.FlatAppearance.BorderSize = 0;
            this.btnListeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeler.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeler.Image = ((System.Drawing.Image)(resources.GetObject("btnListeler.Image")));
            this.btnListeler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListeler.Location = new System.Drawing.Point(0, 259);
            this.btnListeler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListeler.Name = "btnListeler";
            this.btnListeler.Size = new System.Drawing.Size(220, 75);
            this.btnListeler.TabIndex = 0;
            this.btnListeler.Text = "Listeler";
            this.btnListeler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListeler.UseVisualStyleBackColor = false;
            this.btnListeler.Click += new System.EventHandler(this.btnListeler_Click);
            // 
            // btnCiftciler
            // 
            this.btnCiftciler.BackColor = System.Drawing.Color.Tan;
            this.btnCiftciler.FlatAppearance.BorderSize = 0;
            this.btnCiftciler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiftciler.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiftciler.Image = ((System.Drawing.Image)(resources.GetObject("btnCiftciler.Image")));
            this.btnCiftciler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCiftciler.Location = new System.Drawing.Point(0, 180);
            this.btnCiftciler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCiftciler.Name = "btnCiftciler";
            this.btnCiftciler.Size = new System.Drawing.Size(220, 75);
            this.btnCiftciler.TabIndex = 0;
            this.btnCiftciler.Text = "Çiftçiler";
            this.btnCiftciler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCiftciler.UseVisualStyleBackColor = false;
            this.btnCiftciler.Click += new System.EventHandler(this.btnCiftciler_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(213, 639);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 43);
            this.panel1.TabIndex = 3;
            // 
            // lblConnectionStringInfo
            // 
            this.lblConnectionStringInfo.AutoSize = true;
            this.lblConnectionStringInfo.Location = new System.Drawing.Point(3, 14);
            this.lblConnectionStringInfo.Name = "lblConnectionStringInfo";
            this.lblConnectionStringInfo.Size = new System.Drawing.Size(23, 17);
            this.lblConnectionStringInfo.TabIndex = 0;
            this.lblConnectionStringInfo.Text = "---";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lblKarsılama);
            this.panel2.Location = new System.Drawing.Point(283, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 36);
            this.panel2.TabIndex = 1;
            // 
            // lblKarsılama
            // 
            this.lblKarsılama.AutoSize = true;
            this.lblKarsılama.Location = new System.Drawing.Point(3, 14);
            this.lblKarsılama.Name = "lblKarsılama";
            this.lblKarsılama.Size = new System.Drawing.Size(23, 17);
            this.lblKarsılama.TabIndex = 0;
            this.lblKarsılama.Text = "---";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.lblDatetime);
            this.panel3.Location = new System.Drawing.Point(474, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 36);
            this.panel3.TabIndex = 1;
            // 
            // lblDatetime
            // 
            this.lblDatetime.AutoSize = true;
            this.lblDatetime.Location = new System.Drawing.Point(3, 14);
            this.lblDatetime.Name = "lblDatetime";
            this.lblDatetime.Size = new System.Drawing.Size(23, 17);
            this.lblDatetime.TabIndex = 0;
            this.lblDatetime.Text = "---";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.lblConnectionStringInfo);
            this.panel4.Location = new System.Drawing.Point(597, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 36);
            this.panel4.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelsol);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoşgeldiniz.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelsol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Panel panelsol;
        private System.Windows.Forms.Button btnCiftciler;
        private System.Windows.Forms.Button btnListeler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConnectionStringInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblKarsılama;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDatetime;
        private System.Windows.Forms.Panel panel4;
    }
}
