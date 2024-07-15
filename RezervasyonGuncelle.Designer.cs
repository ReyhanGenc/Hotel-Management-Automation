
namespace vt_proje
{
    partial class RezervasyonGuncelle
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rezNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.odaNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(360, 168);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(173, 50);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Değiştirmek istediğiniz rezervasyonun numarası:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rezNo
            // 
            this.rezNo.Location = new System.Drawing.Point(360, 33);
            this.rezNo.Name = "rezNo";
            this.rezNo.Size = new System.Drawing.Size(173, 22);
            this.rezNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yeni Oda Numarası:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // odaNo
            // 
            this.odaNo.Location = new System.Drawing.Point(360, 95);
            this.odaNo.Name = "odaNo";
            this.odaNo.Size = new System.Drawing.Size(173, 22);
            this.odaNo.TabIndex = 4;
            // 
            // RezervasyonGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.odaNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rezNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Name = "RezervasyonGuncelle";
            this.Text = "RezervasyonGuncelle";
            this.Load += new System.EventHandler(this.RezervasyonGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rezNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox odaNo;
    }
}