namespace WinForm.Forms
{
    partial class Dilekce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dilekce));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDilekceUpdateDelete = new System.Windows.Forms.Button();
            this.btnDilekceEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 378);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDilekceUpdateDelete);
            this.panel1.Controls.Add(this.btnDilekceEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 121);
            this.panel1.TabIndex = 2;
            // 
            // btnDilekceUpdateDelete
            // 
            this.btnDilekceUpdateDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDilekceUpdateDelete.Image")));
            this.btnDilekceUpdateDelete.Location = new System.Drawing.Point(117, 12);
            this.btnDilekceUpdateDelete.Name = "btnDilekceUpdateDelete";
            this.btnDilekceUpdateDelete.Size = new System.Drawing.Size(109, 89);
            this.btnDilekceUpdateDelete.TabIndex = 1;
            this.btnDilekceUpdateDelete.Text = "Dilekçe Güncelle\\Sil";
            this.btnDilekceUpdateDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDilekceUpdateDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDilekceUpdateDelete.UseVisualStyleBackColor = true;
            this.btnDilekceUpdateDelete.Click += new System.EventHandler(this.btnDilekceUpdateDelete_Click);
            // 
            // btnDilekceEkle
            // 
            this.btnDilekceEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnDilekceEkle.Image")));
            this.btnDilekceEkle.Location = new System.Drawing.Point(12, 12);
            this.btnDilekceEkle.Name = "btnDilekceEkle";
            this.btnDilekceEkle.Size = new System.Drawing.Size(99, 89);
            this.btnDilekceEkle.TabIndex = 0;
            this.btnDilekceEkle.Text = "Dilekçe Ekle";
            this.btnDilekceEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDilekceEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDilekceEkle.UseVisualStyleBackColor = true;
            this.btnDilekceEkle.Click += new System.EventHandler(this.btnDilekceEkle_Click);
            // 
            // Dilekce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 499);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Dilekce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dilekce";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dilekce_FormClosed);
            this.Load += new System.EventHandler(this.Dilekce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDilekceEkle;
        private System.Windows.Forms.Button btnDilekceUpdateDelete;
    }
}