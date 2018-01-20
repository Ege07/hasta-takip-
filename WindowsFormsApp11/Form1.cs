using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnHastaEkle_Click(object sender, EventArgs e)
        {
            DateTime dogumTarihi = dateDogumTarihi.Value;

           
            Hasta_Takip hasta = new Hasta_Takip
            {
                Adi = txtAdi.Text,
                Ucret = Convert.ToInt32(txtÜcret.Text),
                DogumYili = dogumTarihi.Year,
                Cinsiyet = cmbCinsiyet.Text,

            };
            hasta.YasHesapla();
            hasta.İndirimliUcretHesapla();

            

            dataGridView1.Rows.Add(hasta.Adi,hasta.DogumYili, hasta.Cinsiyet, hasta.Ucret, hasta.indirimliÜcret,hasta.yas);


        }
    }
}
