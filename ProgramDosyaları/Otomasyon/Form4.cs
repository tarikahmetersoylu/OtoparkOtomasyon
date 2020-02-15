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
    public partial class Form4 : MetroForm
    {


        Boolean durum;
        string plaka1 = "";
        string marka1 = "";
        string model1 = "";
        string renk1 = "";
        string aracGirisId;
        string girisTarihi = "";
        string abonelik = "";
        public Form4()
        {
            InitializeComponent();
        }

        string plaka = "Örn: 20 ABC 20";
        string marka = "Örn: Opel";
        string model = "Örn: Astra";
        string renk = "Örn: Metalik Gri";

        void GirisPlakaControl()
        {
            if (girisplakaTxt.Text != plaka && girisplakaTxt.TextLength > 4)
            {
                girismarkaTxt.Enabled = true;
            }
            else if (girisplakaTxt.Text != plaka && girisplakaTxt.TextLength > 4)
            {
                girisBtn.Enabled = true;
            }
            else if (girisplakaTxt.Text != plaka && girisplakaTxt.TextLength > 4)
            {
                girisBtn.Enabled = true;
            }
            else if (girisplakaTxt.Text == plaka && girisplakaTxt.TextLength < 5)
            {
                girisBtn.Enabled = false;
            }
        }

        void GirisMarkaControl()
        {
            if (girismarkaTxt.Text != marka && girismarkaTxt.TextLength > 3)
            {
                girismodelTxt.Enabled = true;
            }
            else if (girismarkaTxt.Text == marka && girismarkaTxt.TextLength < 4)
            {
                girismodelTxt.Enabled = false;
            }
        }

        void GirisModelControl()
        {
            if (girismodelTxt.Text != model && girismodelTxt.TextLength > 1)
            {
                girisrenkTxt.Enabled = true;
            }
            else if (girismodelTxt.Text == model && girismodelTxt.TextLength < 2)
            {
                girisrenkTxt.Enabled = false;
            }
        }

        void GirisRenkControl()
        {
            if (girisrenkTxt.Text != renk && girisrenkTxt.TextLength > 2)
            {
                girisBtn.Enabled = true;
            }
            else if (girisrenkTxt.Text == renk && girisrenkTxt.TextLength < 3)
            {
                girisBtn.Enabled = false;
            }
        }

        void enableFalse()
        {
            girismarkaTxt.Enabled = false;
            girismodelTxt.Enabled = false;
            girisrenkTxt.Enabled = false;
            girisBtn.Enabled = false;
            cikisBtn.Enabled = false;
        }

        void CikisPlakaControl()
        {
            if (cikisplakaTxt.TextLength > 4)
            {
                cikisBtn.Enabled = true;
            }
            else if (cikisplakaTxt.TextLength < 5)
            {
                cikisBtn.Enabled = false;
            }
        }


        private void Form4_Load(object sender, EventArgs e)
        {
           
                baglanti.Open();
                string kayit = "SELECT * from aracGirisCikis where cikis_saati='-'";
                MySqlCommand cmd = new MySqlCommand(kayit, baglanti);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridView1.DataSource = dt;
                baglanti.Close();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void aboneRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void misafirRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

       

        private void girismarkaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void girismodelTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void girisrenkTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cikisplakaTxt_TextChanged(object sender, EventArgs e)
        {
            cikisplakaTxt.CharacterCasing = CharacterCasing.Upper;
        }

        private void girisplakaTxt_Enter(object sender, EventArgs e)
        {
            if (girisplakaTxt.Text == plaka)
            {
                girisplakaTxt.Text = "";
                girisplakaTxt.ForeColor = Color.Black;
                girisplakaTxt.Font = new Font(girisplakaTxt.Font, FontStyle.Regular);
            }
        }

        private void girisplakaTxt_Leave(object sender, EventArgs e)
        {
            if (girisplakaTxt.Text == "")
            {
                girisplakaTxt.Text = plaka;
                girisplakaTxt.ForeColor = Color.DarkViolet;
                girisplakaTxt.Font = new Font(girisplakaTxt.Font, FontStyle.Italic);
            }
        }

        private void girismarkaTxt_Enter(object sender, EventArgs e)
        {
            if (girismarkaTxt.Text == marka)
            {
                girismarkaTxt.Text = "";
                girismarkaTxt.ForeColor = Color.Black;
                girismarkaTxt.Font = new Font(girismarkaTxt.Font, FontStyle.Regular);
            }
        }

        private void girismarkaTxt_Leave(object sender, EventArgs e)
        {
            if (girismarkaTxt.Text == "")
            {
                girismarkaTxt.Text = marka;
                girismarkaTxt.ForeColor = Color.DarkCyan;
                girismarkaTxt.Font = new Font(girismarkaTxt.Font, FontStyle.Italic);
            }
        }

        private void girismodelTxt_Enter(object sender, EventArgs e)
        {
            if (girismodelTxt.Text == model)
            {
                girismodelTxt.Text = "";
                girismodelTxt.ForeColor = Color.Black;
                girismodelTxt.Font = new Font(girismodelTxt.Font, FontStyle.Regular);
            }
        }

        private void girismodelTxt_Leave(object sender, EventArgs e)
        {
            if (girismodelTxt.Text == "")
            {
                girismodelTxt.Text = model;
                girismodelTxt.ForeColor = Color.DarkCyan;
                girismodelTxt.Font = new Font(girismodelTxt.Font, FontStyle.Italic);
            }
        }

        private void girisrenkTxt_Enter(object sender, EventArgs e)
        {
            if (girisrenkTxt.Text == renk)
            {
                girisrenkTxt.Text = "";
                girisrenkTxt.ForeColor = Color.Black;
                girisrenkTxt.Font = new Font(girisrenkTxt.Font, FontStyle.Regular);
            }
        }

        private void girisrenkTxt_Leave(object sender, EventArgs e)
        {
            if (girisrenkTxt.Text == "")
            {
                girisrenkTxt.Text = renk;
                girisrenkTxt.ForeColor = Color.DarkCyan;
                girisrenkTxt.Font = new Font(girisrenkTxt.Font, FontStyle.Italic);
            }
        }

        private void cikisplakaTxt_Enter(object sender, EventArgs e)
        {
            if (cikisplakaTxt.Text == plaka)
            {
                cikisplakaTxt.Text = "";
                cikisplakaTxt.ForeColor = Color.Black;
                cikisplakaTxt.Font = new Font(cikisplakaTxt.Font, FontStyle.Regular);
            }
        }

        private void cikisplakaTxt_Leave(object sender, EventArgs e)
        {
            if (cikisplakaTxt.Text == "")
            {
                cikisplakaTxt.Text = plaka;
                cikisplakaTxt.ForeColor = Color.DarkCyan;
                cikisplakaTxt.Font = new Font(cikisplakaTxt.Font, FontStyle.Italic);
            }
        }

        static string conString = ("Server=localhost;Database=otoparkOtomasyon;Uid=root");
        MySqlConnection baglanti = new MySqlConnection(conString);
        private object cikisPlakaTxt;

        private void girisBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

          

                string giris1 = "insert into aracGirisCikis(giris_saati,cikis_saati,tutar,park_suresi,plaka,aracGiris_id) values (@giris_saati,@cikis_saati,@tutar,@park_suresi,@plaka,@aracGiris_id)";
                MySqlCommand komut1 = new MySqlCommand(giris1, baglanti);
                komut1.Parameters.AddWithValue("@giris_saati", girisTxt.Text);
                komut1.Parameters.AddWithValue("@cikis_saati", "-");
                komut1.Parameters.AddWithValue("@tutar", "-");
                komut1.Parameters.AddWithValue("@park_suresi","-");
                komut1.Parameters.AddWithValue("@plaka", girisplakaTxt.Text);
                komut1.Parameters.AddWithValue("@aracGiris_id", null);
                komut1.ExecuteNonQuery();
                




                baglanti.Close();
                MessageBox.Show("Araç girişi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Araç girişi başarısız! " + hata.Message);
            }
           
            girisplakaTxt.Text = "";
            girismarkaTxt.Text = "";
            girismodelTxt.Text = "";
            girisrenkTxt.Text = "";
            girisTxt.Text = "";
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            if (cikisplakaTxt.Text != plaka)
            {
                
                if (baglanti.State == ConnectionState.Closed && parkSuresiTxt.Text!="" && tutarTxt.Text!="")
                    baglanti.Open();
                if (DataGridView1.SelectedRows.Count > 0 && parkSuresiTxt.Text != "" && tutarTxt.Text != "")
                {
                    string giris = "UPDATE aracGirisCikis SET cikis_saati='" + cikisTarihTxt.Text + "' , tutar='" + tutarTxt.Text + "',park_suresi='" + parkSuresiTxt.Text.ToString() +"' where aracGiris_id='" + DataGridView1.CurrentRow.Cells["aracGiris_id"].Value +"'";
                    MySqlCommand komut = new MySqlCommand(giris, baglanti);
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows[0].Index);
                    MessageBox.Show(cikisplakaTxt.Text + " Plakalı aracın çıkışı başarılı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lüffen silinecek satırı seçin.");
                }


            }
            else
            {
                MessageBox.Show("Geçersiz plaka girişi! Lütfen kontrol edip tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
            saatTxt.Text = time;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cikisplakaTxt.Text = DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            string time = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
            cikisTarihTxt.Text = time;
            if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
            kontrol();

            if (durum == true)
            {
                aboneKontrolTxt.Text = "Yok";
            }
            else
                aboneKontrolTxt.Text = "Var";

        }

        private void saat_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
            girisTxt.Text = time;
        }
        void kontrol()
        {

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select plaka from aboneTc where plaka=@plaka", baglanti);
            string deger = DataGridView1.CurrentRow.Cells["plaka"].Value.ToString();
            komut.Parameters.AddWithValue("@plaka", deger);
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
                
            dr.Close();
        }

        void kontrolPlaka()
        {
            

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select plaka from aboneTc where plaka=@plaka", baglanti);
            komut.Parameters.AddWithValue("@plaka",girisplakaTxt.Text);
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                MySqlCommand komut1 = new MySqlCommand("select * from aboneTc where plaka=@plaka", baglanti);
                komut1.Parameters.AddWithValue("@plaka", girisplakaTxt.Text);
                MySqlDataReader rd = komut1.ExecuteReader();
                if (rd.Read())
                {

                    girismarkaTxt.Text = rd["marka"].ToString();
                    girismodelTxt.Text = rd["model"].ToString();
                    girisrenkTxt.Text = rd["renk"].ToString();
                }
                rd.Close();
            }
            dr.Close();
        }
        private void girisplakaTxt_TextChanged(object sender, EventArgs e)
        {
           
            girisplakaTxt.CharacterCasing = CharacterCasing.Upper;
            kontrolPlaka();
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
