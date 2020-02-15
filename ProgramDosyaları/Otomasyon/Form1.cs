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

namespace Otomasyon
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Form2 abonekayit = new Form2();
            abonekayit.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Form3 duzenle = new Form3();
            duzenle.ShowDialog();
        }

		private void girisBtn_Click(object sender, EventArgs e)
		{
			Form4 giriscikis = new Form4();
			giriscikis.ShowDialog();

		}

		private void metroTile2_Click(object sender, EventArgs e)
		{
            Form5 son = new Form5();
            son.ShowDialog();
        }
	}
}
