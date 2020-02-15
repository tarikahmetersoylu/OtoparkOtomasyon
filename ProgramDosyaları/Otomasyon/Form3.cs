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
using System.Data.OleDb;

namespace Otomasyon
{
	public partial class Form3 : MetroForm
	{
		public Form3()
		{
			InitializeComponent();
		}

		static string con = ("Server=localhost;Database=otoparkOtomasyon;Uid=root");

        MySqlConnection baglanti = new MySqlConnection(con);
		MySqlCommand cmd;
		MySqlDataAdapter da;
		DataTable dt;
		string kayit;

		string tc = "Örn: 12345678900";
		string telno = "Örn: 5415414141";
		string ad = "Örn: Hasan Ali";
		string soyad = "Örn: ÖZDEMİR";
		string plaka = "Örn: 20 ABC 20";
		string marka = "Örn: Opel";
		string model = "Örn: Astra";
		string renk = "Örn: Metalik Gri";
		string adres = "Örn: Kabaoğlu Mahallesi, Baki Komsuoğlu bulvarı No:515, 41380 Umuttepe İzmit/İzmit/Kocaeli";

		string ara = "Ara";

		private void kayitGetir()
		{
			baglanti.Open();
			kayit = "select  A.Tc,A.ad,A.soyad,A.telNo,A.adres,B.plaka,B.marka,B.model,B.renk from aboneKayitBilgi A, aboneTc B where A.TC=B.TC;";
			cmd = new MySqlCommand(kayit, baglanti);
			da = new MySqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			baglanti.Close();
		}

		void adaGoreAra()
		{
			baglanti.Open();
			dt = new DataTable();
			string adagoreara, ad_ara;
			adagoreara = adaraTxt.Text;
			ad_ara = "Select * from aboneKayitBilgi where ad like '%" + adaraTxt.Text + "%'";
			da = new MySqlDataAdapter(ad_ara, baglanti);
			da.Fill(dt);
			baglanti.Close();
			dataGridView1.DataSource = dt;
		}

		void soyadaGoreAra()
		{
			baglanti.Open();
			dt = new DataTable();
			string soyadara, soyad_ara;
			soyadara = soyadaraTxt.Text;
			soyad_ara = "Select * from aboneKayitBilgi where soyad like '%" + soyadaraTxt.Text + "%'";
			da = new MySqlDataAdapter(soyad_ara, baglanti);
			da.Fill(dt);
			baglanti.Close();
			dataGridView1.DataSource = dt;
		}

		void tcGoreAra()
		{
			baglanti.Open();
			DataTable tbl = new DataTable();
			string tcara, tc_ara;
			tcara = tcaraTxt.Text;
			tc_ara = "Select * from aboneKayitBilgi where TC like '%" + tcaraTxt.Text + "%'";
			MySqlDataAdapter da = new MySqlDataAdapter(tc_ara, baglanti);
			da.Fill(tbl);
			baglanti.Close();
			dataGridView1.DataSource = tbl;
		}

		void telnoGoreAra()
		{
			baglanti.Open();
			DataTable tbl = new DataTable();
			string telara, tel_ara;
			telara = telnoaraTxt.Text;
			tel_ara = "Select * from aboneKayitBilgi where telNo like '%" + telnoaraTxt.Text + "%'";
			MySqlDataAdapter da = new MySqlDataAdapter(tel_ara, baglanti);
			da.Fill(tbl);
			baglanti.Close();
			dataGridView1.DataSource = tbl;
		}

		void plakayaGoreAra()
		{
			baglanti.Open();
			DataTable tbl = new DataTable();
			string plakaara, plaka_ara;
			plakaara = plakaaraTxt.Text;
			plaka_ara = "Select * from aboneTc where plaka like '%" + plakaaraTxt.Text + "%'";
			MySqlDataAdapter da = new MySqlDataAdapter(plaka_ara, baglanti);
			da.Fill(tbl);
			baglanti.Close();
			dataGridView1.DataSource = tbl;
		}

		void rengeGoreAra()
		{
			baglanti.Open();
			DataTable tbl = new DataTable();
			string renkara, renk_ara;
			renkara = renkaraTxt.Text;
			renk_ara = "Select * from aboneKayitBilgi where renk like '%" + renkaraTxt.Text + "%'";
			MySqlDataAdapter da = new MySqlDataAdapter(renk_ara, baglanti);
			da.Fill(tbl);
			baglanti.Close();
			dataGridView1.DataSource = tbl;
		}

		void markayaGoreAra()
		{
			baglanti.Open();
			DataTable tbl = new DataTable();
			string markaara, marka_ara;
			markaara = markaaraTxt.Text;
			marka_ara = "Select * from aboneKayitBilgi where marka like '%" + markaaraTxt.Text + "%'";
			MySqlDataAdapter da = new MySqlDataAdapter(marka_ara, baglanti);
			da.Fill(tbl);
			baglanti.Close();
			dataGridView1.DataSource = tbl;
		}

		void modeleGoreAra()
		{
			baglanti.Open();
			DataTable tbl = new DataTable();
			string modelara, model_ara;
			modelara = modelaraTxt.Text;
			model_ara = "Select * from aboneKayitBilgi where model like '%" + modelaraTxt.Text + "%'";
			MySqlDataAdapter da = new MySqlDataAdapter(model_ara, baglanti);
			da.Fill(tbl);
			baglanti.Close();
			dataGridView1.DataSource = tbl;
		}

		MySqlConnection baglan;
		MySqlCommand commnd;

		void kayitSil(int TC)
		{
			string sql = "DELETE FROM aboneKayit WHERE TC=@TC";
			commnd = new MySqlCommand(sql, baglan);
			commnd.Parameters.AddWithValue("@TC", TC);
			baglan.Open();
			commnd.ExecuteNonQuery();
			baglan.Close();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			kayitGetir();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void toolStripTextBox1_Enter(object sender, EventArgs e)
		{
		}

		private void duzenAraTxt_Leave(object sender, EventArgs e)
		{
		}

		private void yardımToolStripButton_Click(object sender, EventArgs e)
		{
			string madde1, madde2, madde3;
			madde1 = "1- 'ARA' kısmına düzenlemek istediğiniz kullanıcının TC Kimlik Numarası, Adı, Soyadı, Araç Plakası... vb özellikleri yazarak kullanabilirsiniz.";
			madde2 = "2- Kaydını düzenlemek/silmek istediğiniz bilginin üzerine tıklayınız.";
			madde3 = "3- Kayıt düzenlemeniz/silmeniz güncel olarak kaydedilecektir";
			MessageBox.Show(madde1 + "\n" + madde2 + "\n" + madde3);
		}

		private void toolStripTextBox1_Click(object sender, EventArgs e)
		{

		}

		private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void toolStripTextBox1_TextChanged_1(object sender, EventArgs e)
		{
			adaGoreAra();
		}

		private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
		{
			soyadaGoreAra();
		}

		private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
		{
			tcGoreAra();
		}

		private void toolStripTextBox4_TextChanged(object sender, EventArgs e)
		{
			telnoGoreAra();
		}

		private void toolStripTextBox5_TextChanged(object sender, EventArgs e)
		{
			plakayaGoreAra();
		}

		private void toolStripTextBox6_TextChanged(object sender, EventArgs e)
		{
			rengeGoreAra();
		}

		private void toolStripTextBox7_TextChanged(object sender, EventArgs e)
		{
			markayaGoreAra();
		}

		private void toolStripTextBox8_TextChanged(object sender, EventArgs e)
		{
			modeleGoreAra();
		}

		private void silToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}



		private void silToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			int selectedIndex = dataGridView1.CurrentCell.RowIndex;
			if (selectedIndex > -1)
			{
				dataGridView1.Rows.RemoveAt(selectedIndex);
				dataGridView1.Refresh();
			}
		}







		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void markaToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void adToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void Form3_Load_1(object sender, EventArgs e)
		{
			kayitGetir();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			tc1Txt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			kayitAd1Txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			kayitSoyad1Txt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			telnoMasked1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			kayitAdres1Txt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			kayitAracPlaka1Txt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			kayitAracMarka1Txt.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			kayitAracModel1Txt.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
			kayitAracRenk1Txt.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();



		}

		private void guncelleBtn_Click(object sender, EventArgs e)
		{
			if (baglanti.State == ConnectionState.Closed)
				baglanti.Open();


			if (tc1Txt.Modified)
			{
				string giris = "UPDATE aboneTc SET TC='" + tc1Txt.Text + "' where TC='" + dataGridView1.CurrentRow.Cells["Tc"].Value + "'";
				MySqlCommand komut = new MySqlCommand(giris, baglanti);
				komut.ExecuteNonQuery();
				komut.Dispose();


				string giris1 = "UPDATE aboneKayitBilgi SET TC='" + tc1Txt.Text + "' where TC='" + dataGridView1.CurrentRow.Cells["Tc"].Value + "'";
				MySqlCommand komut1 = new MySqlCommand(giris1, baglanti);
				komut1.ExecuteNonQuery();
				komut1.Dispose();


			}

			if (kayitAracPlaka1Txt.Modified)
			{
				string giris2 = "UPDATE aboneTc SET plaka='" + kayitAracPlaka1Txt.Text + "' where plaka='" + dataGridView1.CurrentRow.Cells["plaka"].Value + "'";
				MySqlCommand komut2 = new MySqlCommand(giris2, baglanti);
				komut2.ExecuteNonQuery();
				komut2.Dispose();

				string giris3 = "UPDATE aracKayitBilgi SET plaka='" + kayitAracPlaka1Txt.Text + "' where plaka='" + dataGridView1.CurrentRow.Cells["plaka"].Value + "'";
				MySqlCommand komut3 = new MySqlCommand(giris3, baglanti);
				komut3.ExecuteNonQuery();
				komut3.Dispose();

				string giris4 = "UPDATE aracGirisCikis SET plaka='" + kayitAracPlaka1Txt.Text + "' where plaka='" + dataGridView1.CurrentRow.Cells["plaka"].Value + "'";
				MySqlCommand komut4 = new MySqlCommand(giris4, baglanti);
				komut4.ExecuteNonQuery();
				komut4.Dispose();


			}

			if (kayitAd1Txt.Modified)
			{

				string giris5 = "UPDATE aboneKayitBilgi SET ad='" + kayitAd1Txt.Text + "' where ad='" + dataGridView1.CurrentRow.Cells["ad"].Value + "'";
				MySqlCommand komut5 = new MySqlCommand(giris5, baglanti);
				komut5.ExecuteNonQuery();
				komut5.Dispose();


			}

			if (kayitSoyad1Txt.Modified)
			{

				string giris6 = "UPDATE aboneKayitBilgi SET soyad='" + kayitSoyad1Txt.Text + "' where soyad='" + dataGridView1.CurrentRow.Cells["soyad"].Value + "'";
				MySqlCommand komut6 = new MySqlCommand(giris6, baglanti);
				komut6.ExecuteNonQuery();
				komut6.Dispose();


			}

			if (telnoMasked1.Modified)
			{

				string giris7 = "UPDATE aboneKayitBilgi SET telNo='" + telnoMasked1.Text + "' where telNo='" + dataGridView1.CurrentRow.Cells["telNo"].Value + "'";
				MySqlCommand komut7 = new MySqlCommand(giris7, baglanti);
				komut7.ExecuteNonQuery();
				komut7.Dispose();


			}

			if (kayitAdres1Txt.Modified)
			{

				string giris8 = "UPDATE aboneKayitBilgi SET adres='" + kayitAdres1Txt.Text + "' where adres='" + dataGridView1.CurrentRow.Cells["adres"].Value + "'and TC='" + dataGridView1.CurrentRow.Cells["TC"].Value + "' ";
				MySqlCommand komut8 = new MySqlCommand(giris8, baglanti);
				komut8.ExecuteNonQuery();
				komut8.Dispose();


			}

			if (kayitAracMarka1Txt.Modified)
			{

				string giris9 = "UPDATE aboneTc SET marka='" + kayitAracMarka1Txt.Text + "' where marka='" + dataGridView1.CurrentRow.Cells["marka"].Value + "'";
				MySqlCommand komut9 = new MySqlCommand(giris9, baglanti);
				komut9.ExecuteNonQuery();
				komut9.Dispose();

				string giris10 = "UPDATE aracKayitBilgi SET marka='" + kayitAracMarka1Txt.Text + "' where marka='" + dataGridView1.CurrentRow.Cells["marka"].Value + "'";
				MySqlCommand komut10 = new MySqlCommand(giris10, baglanti);
				komut10.ExecuteNonQuery();
				komut10.Dispose();



			}

			if (kayitAracModel1Txt.Modified)
			{

				string giris11 = "UPDATE aboneTc SET model='" + kayitAracModel1Txt.Text + "' where model='" + dataGridView1.CurrentRow.Cells["model"].Value + "'";
				MySqlCommand komut11 = new MySqlCommand(giris11, baglanti);
				komut11.ExecuteNonQuery();
				komut11.Dispose();

				string giris12 = "UPDATE aracKayitBilgi SET model='" + kayitAracModel1Txt.Text + "' where model='" + dataGridView1.CurrentRow.Cells["model"].Value + "'";
				MySqlCommand komut12 = new MySqlCommand(giris12, baglanti);
				komut12.ExecuteNonQuery();
				komut12.Dispose();



			}

			if (kayitAracRenk1Txt.Modified)
			{

				string giris13 = "UPDATE aboneTc SET renk='" + kayitAracRenk1Txt.Text + "' where renk='" + dataGridView1.CurrentRow.Cells["renk"].Value + "'";
				MySqlCommand komut13 = new MySqlCommand(giris13, baglanti);
				komut13.ExecuteNonQuery();
				komut13.Dispose();

				string giris14 = "UPDATE aracKayitBilgi SET renk='" + kayitAracRenk1Txt.Text + "' where renk='" + dataGridView1.CurrentRow.Cells["renk"].Value + "'";
				MySqlCommand komut14 = new MySqlCommand(giris14, baglanti);
				komut14.ExecuteNonQuery();
				komut14.Dispose();



			}
			MessageBox.Show("Güncelleme başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void toolStripTextBox1_TextChanged_2(object sender, EventArgs e)
		{
			adaGoreAra();
		}

		private void soyadaraTxt_TextChanged(object sender, EventArgs e)
		{
			soyadaGoreAra();
		}

		private void tcaraTxt_TextChanged(object sender, EventArgs e)
		{
			tcGoreAra();
		}

		private void telnoaraTxt_TextChanged(object sender, EventArgs e)
		{
			telnoGoreAra();
		}

		private void plakaaraTxt_TextChanged(object sender, EventArgs e)
		{
			plakayaGoreAra();
		}

		private void renkaraTxt_TextChanged(object sender, EventArgs e)
		{
			rengeGoreAra();
		}

		private void markaaraTxt_TextChanged(object sender, EventArgs e)
		{
			markayaGoreAra();
		}

		private void modeleGöreToolStripMenuItem_TextChanged(object sender, EventArgs e)
		{
			modeleGoreAra();
		}

		private void tc1Txt_Enter(object sender, EventArgs e)
		{
			if (tc1Txt.Text == tc)
			{
				tc1Txt.Text = "";
				tc1Txt.ForeColor = Color.Black;
				tc1Txt.Font = new Font(tc1Txt.Font, FontStyle.Regular);
			}
		}

		private void kayitAd1Txt_Enter(object sender, EventArgs e)
		{
			if (kayitAd1Txt.Text == ad)
			{
				kayitAd1Txt.Text = "";
				kayitAd1Txt.ForeColor = Color.Black;
				kayitAd1Txt.Font = new Font(kayitAd1Txt.Font, FontStyle.Regular);
			}
		}

		private void tc1Txt_Leave(object sender, EventArgs e)
		{
			if (tc1Txt.Text == "")
			{
				tc1Txt.Text = tc;
				tc1Txt.ForeColor = Color.DarkViolet;
				tc1Txt.Font = new Font(tc1Txt.Font, FontStyle.Italic);
			}
		}

		private void kayitAd1Txt_Leave(object sender, EventArgs e)
		{
			if (kayitAd1Txt.Text == "")
			{
				kayitAd1Txt.Text = ad;
				kayitAd1Txt.ForeColor = Color.DarkViolet;
				kayitAd1Txt.Font = new Font(kayitAd1Txt.Font, FontStyle.Italic);
			}
		}

		private void kayitSoyad1Txt_Enter(object sender, EventArgs e)
		{
			if (kayitSoyad1Txt.Text == soyad)
			{
				kayitSoyad1Txt.Text = "";
				kayitSoyad1Txt.ForeColor = Color.Black;
				kayitSoyad1Txt.Font = new Font(kayitSoyad1Txt.Font, FontStyle.Regular);
			}
		}

		private void kayitSoyad1Txt_Leave(object sender, EventArgs e)
		{
			if (kayitSoyad1Txt.Text == "")
			{
				kayitSoyad1Txt.Text = soyad;
				kayitSoyad1Txt.ForeColor = Color.DarkViolet;
				kayitSoyad1Txt.Font = new Font(kayitSoyad1Txt.Font, FontStyle.Italic);
			}
		}

		private void kayitSoyad1Txt_TextChanged(object sender, EventArgs e)
		{
			kayitSoyad1Txt.CharacterCasing = CharacterCasing.Upper;
		}

		private void adaraTxt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
			{
				e.Handled = true;
				MessageBox.Show("Ad rakamlardan oluşamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				e.Handled = false;
			}
		}

		private void adaraTxt_Enter(object sender, EventArgs e)
		{

		}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}