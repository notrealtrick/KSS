namespace KSS
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
            this.giris = new System.Windows.Forms.Button();
            this.uyeol = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(208, 292);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(75, 23);
            this.giris.TabIndex = 0;
            this.giris.Text = "Giriş yap";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // uyeol
            // 
            this.uyeol.Location = new System.Drawing.Point(470, 292);
            this.uyeol.Name = "uyeol";
            this.uyeol.Size = new System.Drawing.Size(75, 23);
            this.uyeol.TabIndex = 1;
            this.uyeol.Text = "Üye Ol";
            this.uyeol.UseVisualStyleBackColor = true;
            this.uyeol.Click += new System.EventHandler(this.uyeol_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(298, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 20);
            this.textBox2.TabIndex = 3;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(205, 123);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(63, 13);
            this.id.TabIndex = 4;
            this.id.Text = "Kullanıcı adı";
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Location = new System.Drawing.Point(205, 179);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(28, 13);
            this.sifre.TabIndex = 5;
            this.sifre.Text = "Şifre";
            this.sifre.Click += new System.EventHandler(this.sifre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.id);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uyeol);
            this.Controls.Add(this.giris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Button uyeol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label sifre;
    }
}

