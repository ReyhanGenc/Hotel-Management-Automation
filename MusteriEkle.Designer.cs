
namespace vt_proje
{
    partial class MusteriEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.mustAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mustSoyadi = new System.Windows.Forms.TextBox();
            this.mustOtelNo = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mustAdi
            // 
            this.mustAdi.Location = new System.Drawing.Point(141, 43);
            this.mustAdi.Name = "mustAdi";
            this.mustAdi.Size = new System.Drawing.Size(194, 22);
            this.mustAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müşteri Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Otel Numarası:";
            // 
            // mustSoyadi
            // 
            this.mustSoyadi.Location = new System.Drawing.Point(141, 94);
            this.mustSoyadi.Name = "mustSoyadi";
            this.mustSoyadi.Size = new System.Drawing.Size(194, 22);
            this.mustSoyadi.TabIndex = 5;
            // 
            // mustOtelNo
            // 
            this.mustOtelNo.Location = new System.Drawing.Point(141, 145);
            this.mustOtelNo.Name = "mustOtelNo";
            this.mustOtelNo.Size = new System.Drawing.Size(194, 22);
            this.mustOtelNo.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(141, 187);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(194, 39);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.mustOtelNo);
            this.Controls.Add(this.mustSoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mustAdi);
            this.Controls.Add(this.label1);
            this.Name = "MusteriEkle";
            this.Text = "MusteriEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mustAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mustSoyadi;
        private System.Windows.Forms.TextBox mustOtelNo;
        private System.Windows.Forms.Button btnEkle;
    }
}