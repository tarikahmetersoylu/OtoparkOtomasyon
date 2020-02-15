using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace Otomasyon
{
    public partial class Form5 : MetroForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        static string conString = ("Server=localhost;Database=otoparkOtomasyon;Uid=root");
        MySqlConnection baglanti = new MySqlConnection(conString);

        private void Form5_Load(object sender, EventArgs e)
        {
           
            baglanti.Open();
            string kayit = "SELECT * from uyelikTarihBilgi";
            MySqlCommand cmd = new MySqlCommand(kayit, baglanti);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
            string kayit1 = "SELECT * from aracGirisCikis where cikis_saati!='-'";
            MySqlCommand cmd1 = new MySqlCommand(kayit1, baglanti);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
           

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView2_AutoSizeRowsModeChanged(object sender, DataGridViewAutoSizeModeEventArgs e)
        {
        
        }
        private void AutoSizeRowsMode(Object sender, EventArgs e)
        {
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();

            string giris = "UPDATE uyelikTarihBilgi SET abonelikBitisTarih='" + time + "' where TC='" + dataGridView1.CurrentRow.Cells["TC"].Value + "'";
            MySqlCommand komut = new MySqlCommand(giris, baglanti);
            komut.ExecuteNonQuery();
            komut.Dispose();

            string giris1 = "delete from aboneTc where TC=(select TC from uyelikTarihBilgi where TC ='" + dataGridView1.CurrentRow.Cells["TC"].Value + "')";
            MySqlCommand komut1 = new MySqlCommand(giris1, baglanti);
            komut1.ExecuteNonQuery();

            string giris2 = "delete from aboneKayitBilgi where TC=(select TC from uyelikTarihBilgi where TC ='" + dataGridView1.CurrentRow.Cells["TC"].Value + "')";
            MySqlCommand komut2 = new MySqlCommand(giris2, baglanti);
            komut2.ExecuteNonQuery();

            MessageBox.Show("Abonelik Sonlandırıldı.");

           
    }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void plakaAraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
