using NotKayitSistemi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotKayitSistemi
{
    public partial class Form1 : Form
    {
        AppDbContext context = new AppDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            if (egitmenChck.Checked == true && ogrenciChck.Checked == false)
            {
                EgitmenGiris();
            }
            else if (ogrenciChck.Checked == true && egitmenChck.Checked == false)
            {
                OgrenciGiris();
            }
            else if (ogrenciChck.Checked == true && egitmenChck.Checked == true)
            {
                MessageBox.Show("Lütfen eğitmen veya öğrenci girişlerinden \"birine\" tıklayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(ogrenciChck.Checked == false && egitmenChck.Checked == false)
            {
                MessageBox.Show("Lütfen eğitmen veya öğrenci girişlerinden \"birine\" tıklayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OgrenciGiris()
        {
            var ogrenci = context.Tbl_Student.FirstOrDefault(c => c.Tckn == tcTxt.Text.ToString() && c.Password == sifreTxt.Text.ToString());
            if (ogrenci == null)
            {
                MessageBox.Show("Hatalı giriş yaptınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Ogrenci f1 = new Ogrenci();
                f1.ogrenci = ogrenci;
                f1.Show();
                this.Hide();
            }
        }

        private void EgitmenGiris()
        {
            var egitmen = context.Tbl_Scholar.FirstOrDefault(c => c.Tckn == tcTxt.Text.ToString() && c.Password == sifreTxt.Text.ToString());
            if (egitmen == null)
            {
                MessageBox.Show("Hatalı giriş yaptınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EgitmenForm f1 = new EgitmenForm();
                f1.egitmen = egitmen;
                f1.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            egitmenChck.Checked = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SifremiUnuttum f1 = new SifremiUnuttum();
            f1.Show();
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            Kayit f1 = new Kayit();
            f1.Show();
        }
    }
}
