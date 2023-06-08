namespace KSS
{
    partial class AdminGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGuncelle));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtbox_sifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbox_eposta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbox_soyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbox_ad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.Font = new System.Drawing.Font("Segoe Script", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(273, 710);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "KSS";
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cmb_cinsiyet.ForeColor = System.Drawing.Color.Transparent;
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmb_cinsiyet.Location = new System.Drawing.Point(368, 449);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(121, 24);
            this.cmb_cinsiyet.TabIndex = 22;
            this.cmb_cinsiyet.Text = "cinsiyet";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.DimGray;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(368, 393);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.MaxLength = 32767;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(379, 33);
            this.bunifuMaterialTextbox1.TabIndex = 21;
            this.bunifuMaterialTextbox1.Text = "Şifre";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.DimGray;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(368, 329);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.MaxLength = 32767;
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(379, 33);
            this.bunifuMaterialTextbox2.TabIndex = 20;
            this.bunifuMaterialTextbox2.Text = "Cinsiyet";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(537, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 1);
            this.label3.TabIndex = 19;
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(537, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "GÜNCELLE";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Kayıt";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(580, 481);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(292, 41);
            this.bunifuThinButton21.TabIndex = 17;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // txtbox_sifre
            // 
            this.txtbox_sifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbox_sifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbox_sifre.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbox_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtbox_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbox_sifre.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_sifre.HintText = "";
            this.txtbox_sifre.isPassword = false;
            this.txtbox_sifre.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtbox_sifre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbox_sifre.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtbox_sifre.LineThickness = 3;
            this.txtbox_sifre.Location = new System.Drawing.Point(368, 270);
            this.txtbox_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_sifre.MaxLength = 32767;
            this.txtbox_sifre.Name = "txtbox_sifre";
            this.txtbox_sifre.Size = new System.Drawing.Size(379, 33);
            this.txtbox_sifre.TabIndex = 16;
            this.txtbox_sifre.Text = "Şifre";
            this.txtbox_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtbox_eposta
            // 
            this.txtbox_eposta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbox_eposta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbox_eposta.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbox_eposta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtbox_eposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbox_eposta.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_eposta.HintText = "";
            this.txtbox_eposta.isPassword = false;
            this.txtbox_eposta.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtbox_eposta.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbox_eposta.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtbox_eposta.LineThickness = 3;
            this.txtbox_eposta.Location = new System.Drawing.Point(368, 206);
            this.txtbox_eposta.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_eposta.MaxLength = 32767;
            this.txtbox_eposta.Name = "txtbox_eposta";
            this.txtbox_eposta.Size = new System.Drawing.Size(379, 33);
            this.txtbox_eposta.TabIndex = 15;
            this.txtbox_eposta.Text = "E-posta";
            this.txtbox_eposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtbox_soyad
            // 
            this.txtbox_soyad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbox_soyad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbox_soyad.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbox_soyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtbox_soyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbox_soyad.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_soyad.HintText = "";
            this.txtbox_soyad.isPassword = false;
            this.txtbox_soyad.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtbox_soyad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbox_soyad.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtbox_soyad.LineThickness = 3;
            this.txtbox_soyad.Location = new System.Drawing.Point(368, 148);
            this.txtbox_soyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_soyad.MaxLength = 32767;
            this.txtbox_soyad.Name = "txtbox_soyad";
            this.txtbox_soyad.Size = new System.Drawing.Size(379, 33);
            this.txtbox_soyad.TabIndex = 14;
            this.txtbox_soyad.Text = "Soyad";
            this.txtbox_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtbox_ad
            // 
            this.txtbox_ad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbox_ad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbox_ad.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbox_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtbox_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbox_ad.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_ad.HintText = "";
            this.txtbox_ad.isPassword = false;
            this.txtbox_ad.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtbox_ad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbox_ad.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtbox_ad.LineThickness = 3;
            this.txtbox_ad.Location = new System.Drawing.Point(368, 89);
            this.txtbox_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_ad.MaxLength = 32767;
            this.txtbox_ad.Name = "txtbox_ad";
            this.txtbox_ad.Size = new System.Drawing.Size(379, 33);
            this.txtbox_ad.TabIndex = 13;
            this.txtbox_ad.Text = "Ad";
            this.txtbox_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AdminGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(979, 710);
            this.Controls.Add(this.cmb_cinsiyet);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.txtbox_sifre);
            this.Controls.Add(this.txtbox_eposta);
            this.Controls.Add(this.txtbox_soyad);
            this.Controls.Add(this.txtbox_ad);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "AdminGuncelle";
            this.Text = "AdminGuncelle";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_sifre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_eposta;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_soyad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_ad;
    }
}