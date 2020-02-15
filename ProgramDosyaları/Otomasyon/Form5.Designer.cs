namespace Otomasyon
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümKayıtlardaAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plakaAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişSaatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkSüresiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyelikBilgilerindeAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonelikBaşlangıçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(290, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(159, 105);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(661, 185);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.AutoSizeRowsModeChanged += new System.Windows.Forms.DataGridViewAutoSizeModeEventHandler(this.dataGridView2_AutoSizeRowsModeChanged);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(458, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Üyelik Bilgiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(461, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bütün Kayıtlar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Üyelik Sonlandır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bulToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // bulToolStripMenuItem
            // 
            this.bulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümKayıtlardaAraToolStripMenuItem,
            this.üyelikBilgilerindeAraToolStripMenuItem});
            this.bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            this.bulToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.bulToolStripMenuItem.Text = "Bul";
            // 
            // tümKayıtlardaAraToolStripMenuItem
            // 
            this.tümKayıtlardaAraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plakaAraToolStripMenuItem,
            this.girişSaatiToolStripMenuItem,
            this.parkSüresiToolStripMenuItem});
            this.tümKayıtlardaAraToolStripMenuItem.Name = "tümKayıtlardaAraToolStripMenuItem";
            this.tümKayıtlardaAraToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.tümKayıtlardaAraToolStripMenuItem.Text = "Tüm Kayıtlarda Ara";
            // 
            // plakaAraToolStripMenuItem
            // 
            this.plakaAraToolStripMenuItem.Name = "plakaAraToolStripMenuItem";
            this.plakaAraToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.plakaAraToolStripMenuItem.Text = "Plaka";
            this.plakaAraToolStripMenuItem.Click += new System.EventHandler(this.plakaAraToolStripMenuItem_Click);
            // 
            // girişSaatiToolStripMenuItem
            // 
            this.girişSaatiToolStripMenuItem.Name = "girişSaatiToolStripMenuItem";
            this.girişSaatiToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.girişSaatiToolStripMenuItem.Text = "Giriş Saati";
            // 
            // parkSüresiToolStripMenuItem
            // 
            this.parkSüresiToolStripMenuItem.Name = "parkSüresiToolStripMenuItem";
            this.parkSüresiToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.parkSüresiToolStripMenuItem.Text = "Park Süresi";
            // 
            // üyelikBilgilerindeAraToolStripMenuItem
            // 
            this.üyelikBilgilerindeAraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tCToolStripMenuItem,
            this.abonelikBaşlangıçToolStripMenuItem});
            this.üyelikBilgilerindeAraToolStripMenuItem.Name = "üyelikBilgilerindeAraToolStripMenuItem";
            this.üyelikBilgilerindeAraToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.üyelikBilgilerindeAraToolStripMenuItem.Text = "Üyelik Bilgilerinde Ara";
            // 
            // tCToolStripMenuItem
            // 
            this.tCToolStripMenuItem.Name = "tCToolStripMenuItem";
            this.tCToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.tCToolStripMenuItem.Text = "TC";
            // 
            // abonelikBaşlangıçToolStripMenuItem
            // 
            this.abonelikBaşlangıçToolStripMenuItem.Name = "abonelikBaşlangıçToolStripMenuItem";
            this.abonelikBaşlangıçToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.abonelikBaşlangıçToolStripMenuItem.Text = "Abonelik Başlangıç";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem bulToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tümKayıtlardaAraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem plakaAraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem girişSaatiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem parkSüresiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem üyelikBilgilerindeAraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tCToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abonelikBaşlangıçToolStripMenuItem;
	}
}