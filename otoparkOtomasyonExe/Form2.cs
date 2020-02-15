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
	public partial class Form2 : MetroForm
	{
		public Form2()
		{
			InitializeComponent();
		}

		string tc = "Örn: 12345678900";
		string telno = "Örn: 5415414141";
		string ad = "Örn: Hasan Ali";
		string soyad = "Örn: ÖZDEMİR";
		string plaka = "Örn: 20 ABC 20";
		string marka = "Örn: Opel";
		string model = "Örn: Astra";
		string renk = "Örn: Metalik Gri";
		string adres = "Örn: Kabaoğlu Mahallesi, Baki Komsuoğlu bulvarı No:515, 41380 Umuttepe İzmit/İzmit/Kocaeli";

		void kayitSonrasi()
		{
			tcTxt.Text = "";
			kayitAdTxt.Text = "";
			kayitSoyadTxt.Text = "";
			kayitAdresTxt.Text = "";
			kayitAracPlakaTxt.Text = "";
			kayitAracMarkaTxt.Text = "";
			kayitAracModelTxt.Text = "";
			kayitAracRenkTxt.Text = "";
		}


		private void Form2_Load(object sender, EventArgs e)
		{
			tcTxt.MaxLength = 11;
			telnoMasked.MaxLength = 11;
			kayitAdTxt.MaxLength = 45;
			kayitSoyadTxt.MaxLength = 45;
			kayitAracPlakaTxt.MaxLength = 11;
			kayitAracMarkaTxt.MaxLength = 25;
			kayitAracModelTxt.MaxLength = 25;
			kayitAracRenkTxt.MaxLength = 25;
			//enabledFalse();
		}

		private void kayitTcTxt_SizeChanged(object sender, EventArgs e)
		{

		}

		private void kayitTcTxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void kayitAdTxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void kayitSoyadTxt_TextChanged(object sender, EventArgs e)
		{
			kayitSoyadTxt.CharacterCasing = CharacterCasing.Upper;
		}

		private void telnoMasked_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void kayitAdresTxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void kayitAracPlakaTxt_TextChanged(object sender, EventArgs e)
		{
			kayitAracPlakaTxt.CharacterCasing = CharacterCasing.Upper;
		}

		private void kayitAracMarkaTxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void kayitAracModelTxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void kayitAracRenkTxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void kayitTcTxt_MouseLeave(object sender, EventArgs e)
		{

		}






		private void kayitAdTxt_Enter(object sender, EventArgs e)
		{
			if (kayitAdTxt.Text == ad)
			{
				kayitAdTxt.Text = "";
				kayitAdTxt.ForeColor = Color.Black;
				kayitAdTxt.Font = new Font(kayitAdTxt.Font, FontStyle.Regular);
			}
		}

		private void kayitAdTxt_Leave(object sender, EventArgs e)
		{
			if (kayitAdTxt.Text == "")
			{
				kayitAdTxt.Text = ad;
				kayitAdTxt.ForeColor = Color.DarkViolet;
				kayitAdTxt.Font = new Font(kayitAdTxt.Font, FontStyle.Italic);
			}
		}

		private void kayitSoyadTxt_Enter(object sender, EventArgs e)
		{
			if (kayitSoyadTxt.Text == soyad)
			{
				kayitSoyadTxt.Text = "";
				kayitSoyadTxt.ForeColor = Color.Black;
				kayitSoyadTxt.Font = new Font(kayitSoyadTxt.Font, FontStyle.Regular);
			}
		}

		private void kayitSoyadTxt_Leave(object sender, EventArgs e)
		{
			if (kayitSoyadTxt.Text == "")
			{
				kayitSoyadTxt.Text = soyad;
				kayitSoyadTxt.ForeColor = Color.DarkViolet;
				kayitSoyadTxt.Font = new Font(kayitSoyadTxt.Font, FontStyle.Italic);
			}
		}

		private void kayitAracPlakaTxt_Enter(object sender, EventArgs e)
		{
			if (kayitAracPlakaTxt.Text == plaka)
			{
				kayitAracPlakaTxt.Text = "";
				kayitAracPlakaTxt.ForeColor = Color.Black;
				kayitAracPlakaTxt.Font = new Font(kayitAracPlakaTxt.Font, FontStyle.Regular);
			}
		}

		private void kayitAracPlakaTxt_Leave(object sender, EventArgs e)
		{
			if (kayitAracPlakaTxt.Text == "")
			{
				kayitAracPlakaTxt.Text = plaka;
				kayitAracPlakaTxt.ForeColor = Color.DarkViolet;
				kayitAracPlakaTxt.Font = new Font(kayitAracPlakaTxt.Font, FontStyle.Italic);
			}
		}

		private void kayitAracMarkaTxt_Enter(object sender, EventArgs e)
		{
			if (kayitAracMarkaTxt.Text == marka)
			{
				kayitAracMarkaTxt.Text = "";
				kayitAracMarkaTxt.ForeColor = Color.Black;
				kayitAracMarkaTxt.Font = new Font(kayitAracMarkaTxt.Font, FontStyle.Regular);
			}
		}

		private void kayitAracMarkaTxt_Leave(object sender, EventArgs e)
		{
			if (kayitAracMarkaTxt.Text == "")
			{
				kayitAracMarkaTxt.Text = marka;
				kayitAracMarkaTxt.ForeColor = Color.DarkViolet;
				kayitAracMarkaTxt.Font = new Font(kayitAracMarkaTxt.Font, FontStyle.Italic);
			}
		}

		private void telnoMasked_Enter(object sender, EventArgs e)
		{

		}

		private void telnoMasked_Leave(object sender, EventArgs e)
		{

		}

		private void kayitAracModelTxt_Enter(object sender, EventArgs e)
		{
			if (kayitAracModelTxt.Text == model)
			{
				kayitAracModelTxt.Text = "";
				kayitAracModelTxt.ForeColor = Color.Black;
				kayitAracModelTxt.Font = new Font(kayitAracModelTxt.Font, FontStyle.Regular);
			}
		}

		private void kayitAracModelTxt_Leave(object sender, EventArgs e)
		{
			if (kayitAracModelTxt.Text == "")
			{
				kayitAracModelTxt.Text = model;
				kayitAracModelTxt.ForeColor = Color.DarkViolet;
				kayitAracModelTxt.Font = new Font(kayitAracModelTxt.Font, FontStyle.Italic);
			}
		}

		private void kayitAracRenkTxt_Enter(object sender, EventArgs e)
		{
			if (kayitAracRenkTxt.Text == renk)
			{
				kayitAracRenkTxt.Text = "";
				kayitAracRenkTxt.ForeColor = Color.Black;
				kayitAracRenkTxt.Font = new Font(kayitAracRenkTxt.Font, FontStyle.Regular);
			}
		}

		private void kayitAracRenkTxt_Leave(object sender, EventArgs e)
		{
			if (kayitAracRenkTxt.Text == "")
			{
				kayitAracRenkTxt.Text = renk;
				kayitAracRenkTxt.ForeColor = Color.DarkViolet;
				kayitAracRenkTxt.Font = new Font(kayitAracRenkTxt.Font, FontStyle.Italic);
			}
		}

		private void kayitAdresTxt_Enter(object sender, EventArgs e)
		{
			if (kayitAdresTxt.Text == adres)
			{
				kayitAdresTxt.Text = "";
				kayitAdresTxt.ForeColor = Color.Black;
				kayitAdresTxt.Font = new Font(kayitAdresTxt.Font, FontStyle.Regular);
			}
		}

		private void kayitAdresTxt_Leave(object sender, EventArgs e)
		{
			if (kayitAdresTxt.Text == "")
			{
				kayitAdresTxt.Text = adres;
				kayitAdresTxt.ForeColor = Color.DarkViolet;
				kayitAdresTxt.Font = new Font(kayitAdresTxt.Font, FontStyle.Italic);
			}
		}

		private void kayitAdTxt_KeyPress(object sender, KeyPressEventArgs e)
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

		private void kayitSoyadTxt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
			{
				e.Handled = true;
				MessageBox.Show("Soyad rakamlardan oluşamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				e.Handled = false;
			}
		}

        static string conString = ("Server=localhost;Database=otoparkOtomasyon;Uid=root");
        MySqlConnection baglanti = new MySqlConnection(conString);

		private void kayitBtn_Click(object sender, EventArgs e)
		{
			string time = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
			string uyelikDurum = "Üyelik Devam Ediyor";
			try
			{
				if (baglanti.State == ConnectionState.Closed && kayitAdTxt.Text != ad && kayitSoyadTxt.Text != soyad && telnoMasked.Text != "" && kayitAdresTxt.Text != adres && kayitAracPlakaTxt.Text != plaka && kayitAracMarkaTxt.Text != marka && kayitAracModelTxt.Text != model && kayitAracRenkTxt.Text != renk)
					baglanti.Open();

				string kayit = "insert into aboneKayitBilgi(ad,soyad,telNo,adres,TC) values (@ad,@soyad,@telNo,@adres,@TC)";
				MySqlCommand komut = new MySqlCommand(kayit, baglanti);
				komut.Parameters.AddWithValue("@TC", tcTxt.Text);
				komut.Parameters.AddWithValue("@ad", kayitAdTxt.Text);
				komut.Parameters.AddWithValue("@soyad", kayitSoyadTxt.Text);
				komut.Parameters.AddWithValue("@telNo", telnoMasked.Text);
				komut.Parameters.AddWithValue("@adres", kayitAdresTxt.Text);
				komut.ExecuteNonQuery();

				string kayit1 = "insert into aboneTc(TC,plaka,marka,model,renk) values (@TC,@plaka,@marka,@model,@renk)";
				MySqlCommand komut1 = new MySqlCommand(kayit1, baglanti);
				komut1.Parameters.AddWithValue("@TC", tcTxt.Text);
				komut1.Parameters.AddWithValue("@plaka", kayitAracPlakaTxt.Text);
				komut1.Parameters.AddWithValue("@marka", kayitAracMarkaTxt.Text);
				komut1.Parameters.AddWithValue("@model", kayitAracModelTxt.Text);
				komut1.Parameters.AddWithValue("@renk", kayitAracRenkTxt.Text);
				komut1.ExecuteNonQuery();

				string kayit2 = "insert into aracKayitBilgi(plaka,marka,model,renk) values (@plaka,@marka,@model,@renk)";
				MySqlCommand komut2 = new MySqlCommand(kayit2, baglanti);
				komut2.Parameters.AddWithValue("@plaka", kayitAracPlakaTxt.Text);
				komut2.Parameters.AddWithValue("@marka", kayitAracMarkaTxt.Text);
				komut2.Parameters.AddWithValue("@model", kayitAracModelTxt.Text);
				komut2.Parameters.AddWithValue("@renk", kayitAracRenkTxt.Text);
				komut2.ExecuteNonQuery();

				string kayit3 = "insert into uyelikTarihBilgi(uyelik_id,abonelikBaslangicTarih,abonelikBitisTarih,TC) values (@uyelik_id,@abonelikBaslangicTarih,@abonelikBitisTarih,@TC)";
				MySqlCommand komut3 = new MySqlCommand(kayit3, baglanti);
				komut3.Parameters.AddWithValue("@uyelik_id", null);
				komut3.Parameters.AddWithValue("@abonelikBaslangicTarih", time);
				komut3.Parameters.AddWithValue("@abonelikBitisTarih", uyelikDurum);
				komut3.Parameters.AddWithValue("@TC", tcTxt.Text);
				komut3.ExecuteNonQuery();

				baglanti.Close();
				MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception error)
			{
				MessageBox.Show("İşlem Sırasında Hata Oluştu. " + error.Message);
			}
		}

		private void telnoMasked_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57 || e.KeyChar == (char)Keys.Back)
				e.Handled = false;

			else
			{
				MessageBox.Show("Telefon Numarası karakter içeremez!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				e.Handled = true;
			}
		}

		private void telnoMasked_Enter_1(object sender, EventArgs e)
		{
			if (telnoMasked.Text == telno)
			{
				telnoMasked.Text = "";
				telnoMasked.ForeColor = Color.Black;
				telnoMasked.Font = new Font(telnoMasked.Font, FontStyle.Regular);
			}
		}

		private void telnoMasked_Leave_1(object sender, EventArgs e)
		{
			if (telnoMasked.Text == "")
			{
				telnoMasked.Text = telno;
				telnoMasked.ForeColor = Color.DarkViolet;
				telnoMasked.Font = new Font(telnoMasked.Font, FontStyle.Italic);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			string kayit2 = "insert into aboneTc(TC,plaka,marka,model,renk) values (@TC,@plaka,@marka,@model,@renk)";
			MySqlCommand komut2 = new MySqlCommand(kayit2, baglanti);
			komut2.Parameters.AddWithValue("@TC", tcTxt.Text);
			komut2.Parameters.AddWithValue("@plaka", kayitAracPlakaTxt.Text);
			komut2.Parameters.AddWithValue("@marka", kayitAracMarkaTxt.Text);
			komut2.Parameters.AddWithValue("@model", kayitAracModelTxt.Text);
			komut2.Parameters.AddWithValue("@renk", kayitAracRenkTxt.Text);
			komut2.ExecuteNonQuery();

			string kayit3 = "insert into aracKayitBilgi(plaka,marka,model,renk) values (@plaka,@marka,@model,@renk)";
			MySqlCommand komut3 = new MySqlCommand(kayit3, baglanti);
			komut3.Parameters.AddWithValue("@plaka", kayitAracPlakaTxt.Text);
			komut3.Parameters.AddWithValue("@marka", kayitAracMarkaTxt.Text);
			komut3.Parameters.AddWithValue("@model", kayitAracModelTxt.Text);
			komut3.Parameters.AddWithValue("@renk", kayitAracRenkTxt.Text);
			komut3.ExecuteNonQuery();


			baglanti.Close();
			MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void tcTxt_Enter(object sender, EventArgs e)
		{
			if (tcTxt.Text == tc)
			{
				tcTxt.Text = "";
				tcTxt.ForeColor = Color.Black;
				tcTxt.Font = new Font(tcTxt.Font, FontStyle.Regular);
			}
		}

		private void tcTxt_Leave(object sender, EventArgs e)
		{
			if (tcTxt.Text == "")
			{
				tcTxt.Text = tc;
				tcTxt.ForeColor = Color.DarkViolet;
				tcTxt.Font = new Font(tcTxt.Font, FontStyle.Italic);
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				kayitAdTxt.Enabled = false;
				kayitSoyadTxt.Enabled = false;
				telnoMasked.Enabled = false;
				kayitAdresTxt.Enabled = false;
				kayitBtn.Enabled = false;
				ekstraKayit.Enabled = true;
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked)
			{
				kayitAdTxt.Enabled = true;
				kayitSoyadTxt.Enabled = true;
				telnoMasked.Enabled = true;
				kayitAdresTxt.Enabled = true;
				kayitBtn.Enabled = true;
				ekstraKayit.Enabled = false;
			}
			
		}

		private void tcTxt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57 || e.KeyChar == (char)Keys.Back)
				e.Handled = false;

			else
			{
				MessageBox.Show("TC Kimlik Numarası karakter içeremez!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				e.Handled = true;
			}
		}
	}
}