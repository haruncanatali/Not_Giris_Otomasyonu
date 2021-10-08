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
    public partial class Kayit : Form
    {
        AppDbContext context = new AppDbContext();
        public Kayit()
        {
            InitializeComponent();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            if (egitmenChck.Checked == true && ogrenciChck.Checked == false)
            {
                try
                {
                    context.Tbl_Scholar.Add(new Scholar
                    {
                        Tckn = tcTxt.Text.ToString(),
                        Password = sifreTxt.Text.ToString(),
                        PrivateKey = ozelSoruCevapTxt.Text.ToString(),
                        PrivateQuestion = ozelSoruTxt.Text.ToString()
                    });
                    context.SaveChanges();
                    MessageBox.Show("Kaydetme başarılı oldu. Sisteme giriş yapabilirsiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kaydetme başarısız oldu. Hata: "+ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(ogrenciChck.Checked == true && egitmenChck.Checked == false)
            {
                try
                {
                    context.Tbl_Student.Add(new Student
                    {
                        Tckn = tcTxt.Text.ToString(),
                        Password = sifreTxt.Text.ToString(),
                        PrivateKey = ozelSoruCevapTxt.Text.ToString(),
                        PrivateQuestion = ozelSoruTxt.Text.ToString(),
                        Name = adTxt.Text.ToString(),
                        Surname = soyadTxt.Text.ToString(),
                        Exam_1 = 0,
                        Exam_2 = 0,
                        Exam_3 = 0,
                        Average = 0.0m,
                        State = false
                    });
                    context.SaveChanges();
                    MessageBox.Show("Kaydetme başarılı oldu. Sisteme giriş yapabilirsiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kaydetme başarısız oldu. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(ogrenciChck.Checked == true && egitmenChck.Checked == true)
            {
                MessageBox.Show("Lütfen eğitmen veya öğrenci seçeneklerinden \"birini\" seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(ogrenciChck.Checked == false && egitmenChck.Checked == false)
            {
                MessageBox.Show("Lütfen eğitmen veya öğrenci seçeneklerinden \"birini\" seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
