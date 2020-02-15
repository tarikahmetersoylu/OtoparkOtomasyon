namespace Otomasyon
{
    partial class Form2
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tcTxt = new System.Windows.Forms.TextBox();
			this.telnoMasked = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.kayitAracRenkTxt = new System.Windows.Forms.TextBox();
			this.kayitAracModelTxt = new System.Windows.Forms.TextBox();
			this.kayitAracMarkaTxt = new System.Windows.Forms.TextBox();
			this.kayitAracPlakaTxt = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.kayitAdresTxt = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.kayitSoyadTxt = new System.Windows.Forms.TextBox();
			this.kayitAdTxt = new System.Windows.Forms.TextBox();
			this.kayitBtn = new System.Windows.Forms.Button();
			this.ekstraKayit = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tcTxt);
			this.groupBox1.Controls.Add(this.telnoMasked);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.kayitAdresTxt);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.kayitSoyadTxt);
			this.groupBox1.Controls.Add(this.kayitAdTxt);
			this.groupBox1.Location = new System.Drawing.Point(23, 95);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(515, 268);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kişi Bilgileri";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "TC:";
			// 
			// tcTxt
			// 
			this.tcTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tcTxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.tcTxt.Location = new System.Drawing.Point(83, 19);
			this.tcTxt.Name = "tcTxt";
			this.tcTxt.Size = new System.Drawing.Size(186, 20);
			this.tcTxt.TabIndex = 12;
			this.tcTxt.Text = "Örn: 12345678900";
			this.tcTxt.Enter += new System.EventHandler(this.tcTxt_Enter);
			this.tcTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcTxt_KeyPress);
			this.tcTxt.Leave += new System.EventHandler(this.tcTxt_Leave);
			// 
			// telnoMasked
			// 
			this.telnoMasked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.telnoMasked.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.telnoMasked.Location = new System.Drawing.Point(83, 111);
			this.telnoMasked.Name = "telnoMasked";
			this.telnoMasked.Size = new System.Drawing.Size(186, 20);
			this.telnoMasked.TabIndex = 11;
			this.telnoMasked.Text = "Örn: 5415414141";
			this.telnoMasked.Enter += new System.EventHandler(this.telnoMasked_Enter_1);
			this.telnoMasked.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telnoMasked_KeyPress);
			this.telnoMasked.Leave += new System.EventHandler(this.telnoMasked_Leave_1);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pictureBox1);
			this.groupBox2.Controls.Add(this.kayitAracRenkTxt);
			this.groupBox2.Controls.Add(this.kayitAracModelTxt);
			this.groupBox2.Controls.Add(this.kayitAracMarkaTxt);
			this.groupBox2.Controls.Add(this.kayitAracPlakaTxt);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(275, 9);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(240, 268);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Araç Bilgileri";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Image = global::Otomasyon.Properties.Resources._82323479_car_icon_design;
			this.pictureBox1.Location = new System.Drawing.Point(49, 154);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(174, 102);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// kayitAracRenkTxt
			// 
			this.kayitAracRenkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.kayitAracRenkTxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.kayitAracRenkTxt.Location = new System.Drawing.Point(55, 117);
			this.kayitAracRenkTxt.Name = "kayitAracRenkTxt";
			this.kayitAracRenkTxt.Size = new System.Drawing.Size(174, 20);
			this.kayitAracRenkTxt.TabIndex = 7;
			this.kayitAracRenkTxt.Text = "Örn: Metalik Gri";
			this.kayitAracRenkTxt.TextChanged += new System.EventHandler(this.kayitAracRenkTxt_TextChanged);
			this.kayitAracRenkTxt.Enter += new System.EventHandler(this.kayitAracRenkTxt_Enter);
			this.kayitAracRenkTxt.Leave += new System.EventHandler(this.kayitAracRenkTxt_Leave);
			// 
			// kayitAracModelTxt
			// 
			this.kayitAracModelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.kayitAracModelTxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.kayitAracModelTxt.Location = new System.Drawing.Point(55, 81);
			this.kayitAracModelTxt.Name = "kayitAracModelTxt";
			this.kayitAracModelTxt.Size = new System.Drawing.Size(174, 20);
			this.kayitAracModelTxt.TabIndex = 6;
			this.kayitAracModelTxt.Text = "Örn: Astra";
			this.kayitAracModelTxt.TextChanged += new System.EventHandler(this.kayitAracModelTxt_TextChanged);
			this.kayitAracModelTxt.Enter += new System.EventHandler(this.kayitAracModelTxt_Enter);
			this.kayitAracModelTxt.Leave += new System.EventHandler(this.kayitAracModelTxt_Leave);
			// 
			// kayitAracMarkaTxt
			// 
			this.kayitAracMarkaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.kayitAracMarkaTxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.kayitAracMarkaTxt.Location = new System.Drawing.Point(55, 44);
			this.kayitAracMarkaTxt.Name = "kayitAracMarkaTxt";
			this.kayitAracMarkaTxt.Size = new System.Drawing.Size(174, 20);
			this.kayitAracMarkaTxt.TabIndex = 5;
			this.kayitAracMarkaTxt.Text = "Örn: Opel";
			this.kayitAracMarkaTxt.TextChanged += new System.EventHandler(this.kayitAracMarkaTxt_TextChanged);
			this.kayitAracMarkaTxt.Enter += new System.EventHandler(this.kayitAracMarkaTxt_Enter);
			this.kayitAracMarkaTxt.Leave += new System.EventHandler(this.kayitAracMarkaTxt_Leave);
			// 
			// kayitAracPlakaTxt
			// 
			this.kayitAracPlakaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.kayitAracPlakaTxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.kayitAracPlakaTxt.Location = new System.Drawing.Point(55, 13);
			this.kayitAracPlakaTxt.Name = "kayitAracPlakaTxt";
			this.kayitAracPlakaTxt.Size = new System.Drawing.Size(174, 20);
			this.kayitAracPlakaTxt.TabIndex = 4;
			this.kayitAracPlakaTxt.Text = "Örn: 20 ABC 20";
			this.kayitAracPlakaTxt.TextChanged += new System.EventHandler(this.kayitAracPlakaTxt_TextChanged);
			this.kayitAracPlakaTxt.Enter += new System.EventHandler(this.kayitAracPlakaTxt_Enter);
			this.kayitAracPlakaTxt.Leave += new System.EventHandler(this.kayitAracPlakaTxt_Leave);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 84);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(39, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Model:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 47);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "Marka:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 120);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "Renk:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Plaka:";
			// 
			// kayitAdresTxt
			// 
			this.kayitAdresTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.kayitAdresTxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.kayitAdresTxt.Location = new System.Drawing.Point(9, 151);
			this.kayitAdresTxt.Multiline = true;
			this.kayitAdresTxt.Name = "kayitAdresTxt";
			this.kayitAdresTxt.Size = new System.Drawing.Size(260, 111);
			this.kayitAdresTxt.TabIndex = 9;
			this.kayitAdresTxt.Text = "Örn: Kabaoğlu Mahallesi, Baki Komsuoğlu bulvarı No:515, 41380 Umuttepe İzmit/İzmi" +
    "t/Kocaeli";
			this.kayitAdresTxt.TextChanged += new System.EventHandler(this.kayitAdresTxt_TextChanged);
			this.kayitAdresTxt.Enter += new System.EventHandler(this.kayitAdresTxt_Enter);
			this.kayitAdresTxt.Leave += new System.EventHandler(this.kayitAdresTxt_Leave);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Adres:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Telefon No:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Soyad:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ad:";
			// 
			// kayitSoyadTxt
			// 
			this.kayitSoyadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.kayitSoyadTxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.kayitSoyadTxt.Location = new System.Drawing.Point(83, 80);
			this.kayitSoyadTxt.Name = "kayitSoyadTxt";
			this.kayitSoyadTxt.Size = new System.Drawing.Size(186, 20);
			this.kayitSoyadTxt.TabIndex = 3;
			this.kayitSoyadTxt.Text = "Örn: ÖZDEMİR";
			this.kayitSoyadTxt.TextChanged += new System.EventHandler(this.kayitSoyadTxt_TextChanged);
			this.kayitSoyadTxt.Enter += new System.EventHandler(this.kayitSoyadTxt_Enter);
			this.kayitSoyadTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kayitSoyadTxt_KeyPress);
			this.kayitSoyadTxt.Leave += new System.EventHandler(this.kayitSoyadTxt_Leave);
			// 
			// kayitAdTxt
			// 
			this.kayitAdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.kayitAdTxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.kayitAdTxt.Location = new System.Drawing.Point(83, 50);
			this.kayitAdTxt.Name = "kayitAdTxt";
			this.kayitAdTxt.Size = new System.Drawing.Size(186, 20);
			this.kayitAdTxt.TabIndex = 2;
			this.kayitAdTxt.Text = "Örn: Hasan Ali";
			this.kayitAdTxt.TextChanged += new System.EventHandler(this.kayitAdTxt_TextChanged);
			this.kayitAdTxt.Enter += new System.EventHandler(this.kayitAdTxt_Enter);
			this.kayitAdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kayitAdTxt_KeyPress);
			this.kayitAdTxt.Leave += new System.EventHandler(this.kayitAdTxt_Leave);
			// 
			// kayitBtn
			// 
			this.kayitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.kayitBtn.Location = new System.Drawing.Point(32, 369);
			this.kayitBtn.Name = "kayitBtn";
			this.kayitBtn.Size = new System.Drawing.Size(75, 23);
			this.kayitBtn.TabIndex = 0;
			this.kayitBtn.Text = "Genel Kayıt";
			this.kayitBtn.UseVisualStyleBackColor = true;
			this.kayitBtn.Click += new System.EventHandler(this.kayitBtn_Click);
			// 
			// ekstraKayit
			// 
			this.ekstraKayit.Location = new System.Drawing.Point(313, 369);
			this.ekstraKayit.Name = "ekstraKayit";
			this.ekstraKayit.Size = new System.Drawing.Size(118, 23);
			this.ekstraKayit.TabIndex = 1;
			this.ekstraKayit.Text = "Yeni Araç Kayıt";
			this.ekstraKayit.UseVisualStyleBackColor = true;
			this.ekstraKayit.Click += new System.EventHandler(this.button1_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(304, 64);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(170, 17);
			this.radioButton1.TabIndex = 2;
			this.radioButton1.Text = "Kayıtlı Aboneye Yeni Araç Ekle";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(23, 63);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(131, 17);
			this.radioButton2.TabIndex = 3;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Yeni Abone Kaydı Yap";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(577, 415);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.ekstraKayit);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.kayitBtn);
			this.MaximizeBox = false;
			this.Name = "Form2";
			this.Resizable = false;
			this.Text = "ABONE KAYIT";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox kayitAracRenkTxt;
        private System.Windows.Forms.TextBox kayitAracModelTxt;
        private System.Windows.Forms.TextBox kayitAracMarkaTxt;
        private System.Windows.Forms.TextBox kayitAracPlakaTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kayitAdresTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kayitSoyadTxt;
        private System.Windows.Forms.TextBox kayitAdTxt;
        private System.Windows.Forms.Button kayitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox telnoMasked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tcTxt;
        private System.Windows.Forms.Button ekstraKayit;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
	}
}