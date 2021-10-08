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
    public partial class Ogrenci : Form
    {
        public Student ogrenci = null;
        AppDbContext context = new AppDbContext();
        public Ogrenci()
        {
            InitializeComponent();
        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            adLbl.Text = ogrenci.Name;
            soyadLbl.Text = ogrenci.Surname;
            sinav1Lbl.Text = ogrenci.Exam_1.ToString();
            sinav2Lbl.Text = ogrenci.Exam_2.ToString();
            sinav3Lbl.Text = ogrenci.Exam_3.ToString();
            ortalamaLbl.Text = ogrenci.Average.ToString();
            durumLbl.Text = ogrenci.State == true ? "Geçti" : "Kaldı";
            sinifOrtalamasiLbl.Text = context.Tbl_Student.Average(c => c.Average).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TalepForm f1 = new TalepForm();
            f1.user = ogrenci;
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
