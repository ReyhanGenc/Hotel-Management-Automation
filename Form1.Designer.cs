
namespace vt_proje
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
            this.btnMusEkle = new System.Windows.Forms.Button();
            this.btnRezGuncel = new System.Windows.Forms.Button();
            this.btnMusList = new System.Windows.Forms.Button();
            this.btnRezList = new System.Windows.Forms.Button();
            this.btnRezSil = new System.Windows.Forms.Button();
            this.btnRezAra = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMusEkle
            // 
            this.btnMusEkle.Location = new System.Drawing.Point(12, 12);
            this.btnMusEkle.Name = "btnMusEkle";
            this.btnMusEkle.Size = new System.Drawing.Size(192, 76);
            this.btnMusEkle.TabIndex = 0;
            this.btnMusEkle.Text = "Müşteri Ekle";
            this.btnMusEkle.UseVisualStyleBackColor = true;
            this.btnMusEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRezGuncel
            // 
            this.btnRezGuncel.Location = new System.Drawing.Point(210, 12);
            this.btnRezGuncel.Name = "btnRezGuncel";
            this.btnRezGuncel.Size = new System.Drawing.Size(192, 76);
            this.btnRezGuncel.TabIndex = 1;
            this.btnRezGuncel.Text = "Rezervasyon Oda Güncelle";
            this.btnRezGuncel.UseVisualStyleBackColor = true;
            this.btnRezGuncel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMusList
            // 
            this.btnMusList.Location = new System.Drawing.Point(210, 94);
            this.btnMusList.Name = "btnMusList";
            this.btnMusList.Size = new System.Drawing.Size(192, 76);
            this.btnMusList.TabIndex = 2;
            this.btnMusList.Text = "Müşterileri Listele";
            this.btnMusList.UseVisualStyleBackColor = true;
            this.btnMusList.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRezList
            // 
            this.btnRezList.Location = new System.Drawing.Point(408, 94);
            this.btnRezList.Name = "btnRezList";
            this.btnRezList.Size = new System.Drawing.Size(192, 76);
            this.btnRezList.TabIndex = 3;
            this.btnRezList.Text = "Rezervasyonları Listele";
            this.btnRezList.UseVisualStyleBackColor = true;
            this.btnRezList.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnRezSil
            // 
            this.btnRezSil.Location = new System.Drawing.Point(408, 12);
            this.btnRezSil.Name = "btnRezSil";
            this.btnRezSil.Size = new System.Drawing.Size(192, 76);
            this.btnRezSil.TabIndex = 4;
            this.btnRezSil.Text = "Rezervasyon Sil";
            this.btnRezSil.UseVisualStyleBackColor = true;
            this.btnRezSil.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnRezAra
            // 
            this.btnRezAra.Location = new System.Drawing.Point(606, 12);
            this.btnRezAra.Name = "btnRezAra";
            this.btnRezAra.Size = new System.Drawing.Size(192, 76);
            this.btnRezAra.TabIndex = 5;
            this.btnRezAra.Text = "Oda Numarası ile Rezervasyon Ara";
            this.btnRezAra.UseVisualStyleBackColor = true;
            this.btnRezAra.Click += new System.EventHandler(this.btnRezAra_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 265);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRezAra);
            this.Controls.Add(this.btnRezSil);
            this.Controls.Add(this.btnRezList);
            this.Controls.Add(this.btnMusList);
            this.Controls.Add(this.btnRezGuncel);
            this.Controls.Add(this.btnMusEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusEkle;
        private System.Windows.Forms.Button btnRezGuncel;
        private System.Windows.Forms.Button btnMusList;
        private System.Windows.Forms.Button btnRezList;
        private System.Windows.Forms.Button btnRezSil;
        private System.Windows.Forms.Button btnRezAra;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

