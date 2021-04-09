namespace indirim
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblkitap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkitap = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltutar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltoplam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblkitap
            // 
            this.lblkitap.AutoSize = true;
            this.lblkitap.Location = new System.Drawing.Point(51, 28);
            this.lblkitap.Name = "lblkitap";
            this.lblkitap.Size = new System.Drawing.Size(61, 13);
            this.lblkitap.TabIndex = 0;
            this.lblkitap.Text = "Kitap Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Tutar:";
            // 
            // txtkitap
            // 
            this.txtkitap.Location = new System.Drawing.Point(121, 25);
            this.txtkitap.Name = "txtkitap";
            this.txtkitap.Size = new System.Drawing.Size(100, 20);
            this.txtkitap.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(121, 57);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtfiyat.TabIndex = 6;
            this.txtfiyat.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "İndirim Tutar:";
            // 
            // lbltutar
            // 
            this.lbltutar.AutoSize = true;
            this.lbltutar.Location = new System.Drawing.Point(118, 208);
            this.lbltutar.Name = "lbltutar";
            this.lbltutar.Size = new System.Drawing.Size(33, 13);
            this.lbltutar.TabIndex = 7;
            this.lbltutar.Text = "00  tl ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kitap Fiyatı:";
            // 
            // lbltoplam
            // 
            this.lbltoplam.AutoSize = true;
            this.lbltoplam.Location = new System.Drawing.Point(118, 164);
            this.lbltoplam.Name = "lbltoplam";
            this.lbltoplam.Size = new System.Drawing.Size(33, 13);
            this.lbltoplam.TabIndex = 9;
            this.lbltoplam.Text = "00  tl ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 294);
            this.Controls.Add(this.lbltoplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltutar);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtkitap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblkitap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkitap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkitap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltoplam;
    }
}

