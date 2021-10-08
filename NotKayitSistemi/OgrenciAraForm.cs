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
    public partial class OgrenciAraForm : Form
    {
        AppDbContext context = new AppDbContext();
        Student user = new Student();
        EgitmenForm f1 = new EgitmenForm();
        public OgrenciAraForm(EgitmenForm f)
        {
            InitializeComponent();
            this.f1 = f;
        }

        private void tcNoTxt_TextChanged(object sender, EventArgs e)
        {
            if (tcNoTxt.Text.Length == 11)
            {
                user = context.Tbl_Student.FirstOrDefault(c => c.Tckn == tcNoTxt.Text.ToString());

                if (user == null)
                {
                    bulunamadıChck.Checked = true;
                    bulunduChck.Checked = false;
                }
                else
                {
                    bulunamadıChck.Checked = false;
                    bulunduChck.Checked = true;
                }
            }
        }

        private void ogrenciSecBtn_Click(object sender, EventArgs e)
        {
            if (tcNoTxt.Text.Length == 11 && bulunduChck.Checked == true)
            {
                f1.tcGuncelleTxt.Text = user.Tckn;
                f1.sinav1GuncelleTxt.Text = user.Exam_1.ToString();
                f1.sinav2GuncelleTxt.Text = user.Exam_2.ToString();
                f1.sinav3GuncelleTxt.Text = user.Exam_3.ToString();

                this.Close();
            }
        }
    }
}
