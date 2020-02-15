namespace Otomasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.yenikayitBtn = new MetroFramework.Controls.MetroTile();
            this.kayitduzenleBtn = new MetroFramework.Controls.MetroTile();
            this.otoparkgirisBtn = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // yenikayitBtn
            // 
            this.yenikayitBtn.ActiveControl = null;
            this.yenikayitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yenikayitBtn.Location = new System.Drawing.Point(14, 209);
            this.yenikayitBtn.Margin = new System.Windows.Forms.Padding(6);
            this.yenikayitBtn.Name = "yenikayitBtn";
            this.yenikayitBtn.Size = new System.Drawing.Size(257, 128);
            this.yenikayitBtn.TabIndex = 3;
            this.yenikayitBtn.Text = "Yeni Kayıt";
            this.yenikayitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yenikayitBtn.UseSelectable = true;
            this.yenikayitBtn.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // kayitduzenleBtn
            // 
            this.kayitduzenleBtn.ActiveControl = null;
            this.kayitduzenleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kayitduzenleBtn.Location = new System.Drawing.Point(281, 71);
            this.kayitduzenleBtn.Margin = new System.Windows.Forms.Padding(6);
            this.kayitduzenleBtn.Name = "kayitduzenleBtn";
            this.kayitduzenleBtn.Size = new System.Drawing.Size(257, 128);
            this.kayitduzenleBtn.TabIndex = 2;
            this.kayitduzenleBtn.Text = "Kayıt Düzenle";
            this.kayitduzenleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kayitduzenleBtn.UseSelectable = true;
            this.kayitduzenleBtn.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // otoparkgirisBtn
            // 
            this.otoparkgirisBtn.ActiveControl = null;
            this.otoparkgirisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.otoparkgirisBtn.Location = new System.Drawing.Point(14, 71);
            this.otoparkgirisBtn.Margin = new System.Windows.Forms.Padding(6);
            this.otoparkgirisBtn.Name = "otoparkgirisBtn";
            this.otoparkgirisBtn.Size = new System.Drawing.Size(257, 128);
            this.otoparkgirisBtn.TabIndex = 1;
            this.otoparkgirisBtn.Text = "Giriş/Çıkış";
            this.otoparkgirisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.otoparkgirisBtn.UseSelectable = true;
            this.otoparkgirisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.Location = new System.Drawing.Point(282, 211);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(6);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(255, 126);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Genel Bilgiler-Abonelik";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(554, 355);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.otoparkgirisBtn);
            this.Controls.Add(this.kayitduzenleBtn);
            this.Controls.Add(this.yenikayitBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(37, 110, 37, 36);
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "OTOPARK KONTROL SİSTEMİ";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile yenikayitBtn;
        private MetroFramework.Controls.MetroTile kayitduzenleBtn;
        private MetroFramework.Controls.MetroTile otoparkgirisBtn;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}

