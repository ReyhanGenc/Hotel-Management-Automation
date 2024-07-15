
namespace vt_proje
{
    partial class RezervasyonAra
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
            this.btnAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OdaNo = new System.Windows.Forms.TextBox();
            this.OdaRezListele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OdaRezListele)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(230, 84);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(168, 46);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oda Numarasını Giriniz:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OdaNo
            // 
            this.OdaNo.Location = new System.Drawing.Point(230, 43);
            this.OdaNo.Name = "OdaNo";
            this.OdaNo.Size = new System.Drawing.Size(168, 22);
            this.OdaNo.TabIndex = 2;
            // 
            // OdaRezListele
            // 
            this.OdaRezListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdaRezListele.Location = new System.Drawing.Point(55, 148);
            this.OdaRezListele.Name = "OdaRezListele";
            this.OdaRezListele.RowHeadersWidth = 51;
            this.OdaRezListele.RowTemplate.Height = 24;
            this.OdaRezListele.Size = new System.Drawing.Size(681, 259);
            this.OdaRezListele.TabIndex = 4;
            // 
            // RezervasyonAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OdaRezListele);
            this.Controls.Add(this.OdaNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAra);
            this.Name = "RezervasyonAra";
            this.Text = "RezervasyonAra";
            ((System.ComponentModel.ISupportInitialize)(this.OdaRezListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OdaNo;
        private System.Windows.Forms.DataGridView OdaRezListele;
    }
}