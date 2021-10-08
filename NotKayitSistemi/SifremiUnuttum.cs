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
    public partial class SifremiUnuttum : Form
    {
        AppDbContext context = new AppDbContext();
        string cevap = "";
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void degistirBtn_Click(object sender, EventArgs e)
        {
            if (egitmenChck.Checked == true && ogrenciChck.Checked == false && tcTxt.Text.ToString()!=null)
            {
                var cevap_ = cevapTxt.Text.ToString();
                if (cevap_ == cevap)
                {
                    var user = context.Tbl_Scholar.FirstOrDefault(c => c.Tckn == tcTxt.Text.ToString());
                    user.Password = sifreTxt.Text.ToString();
                    context.SaveChanges();
                    MessageBox.Show("Şifre değitirme başarılı oldu. Sisteme giriş yapabilirsiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gizli sorunuza yanlış cevap verdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if(egitmenChck.Checked == false && ogrenciChck.Checked == true && tcTxt.Text.ToString()!=null)
            {
                var cevap_ = cevapTxt.Text.ToString();
                if (cevap_ == cevap)
                {
                    var user = context.Tbl_Student.FirstOrDefault(c => c.Tckn == tcTxt.Text.ToString());
                    user.Password = sifreTxt.Text.ToString();
                    context.SaveChanges();
                    MessageBox.Show("Şifre değitirme başarılı oldu. Sisteme giriş yapabilirsiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gizli sorunuza yanlış cevap verdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hatalı posizyon seçimi/Boş Tc/Boş şifre yaptınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tcTxt_TextChanged(object sender, EventArgs e)
        {
            if (tcTxt.Text.Length == 11 && egitmenChck.Checked == true)
            {
                var user = context.Tbl_Scholar.FirstOrDefault(c => c.Tckn == tcTxt.Text.ToString());
                soruTxt.Text = user.PrivateQuestion;
                cevap = user.PrivateKey;
            }
            else if(tcTxt.Text.Length == 11 && ogrenciChck.Checked == true)
            {
                var user = context.Tbl_Student.FirstOrDefault(c => c.Tckn == tcTxt.Text.ToString());
                soruTxt.Text = user.PrivateQuestion;
                cevap = user.PrivateKey;
            }
        }
    }
}
