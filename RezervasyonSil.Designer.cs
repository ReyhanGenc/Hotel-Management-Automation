
namespace vt_proje
{
    partial class RezervasyonSil
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
            this.rezNo = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silmek istediğiniz rezervasyon numarasını giriniz: ";
            // 
            // rezNo
            // 
            this.rezNo.Location = new System.Drawing.Point(353, 43);
            this.rezNo.Name = "rezNo";
            this.rezNo.Size = new System.Drawing.Size(166, 22);
            this.rezNo.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(353, 86);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(166, 44);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // RezervasyonSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.rezNo);
            this.Controls.Add(this.label1);
            this.Name = "RezervasyonSil";
            this.Text = "RezervasyonSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rezNo;
        private System.Windows.Forms.Button btnSil;
    }
}