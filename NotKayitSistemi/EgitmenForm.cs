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
    public partial class EgitmenForm : Form
    {
        public Scholar egitmen = null;
        AppDbContext context = new AppDbContext();
        List<StudentDto> ogrenciler = new List<StudentDto>();
        public EgitmenForm()
        {
            InitializeComponent();
        }

        private void EgitmenForm_Load(object sender, EventArgs e)
        {
            OgrencileriTanimla();
            GridTanimla();
        }

        private void GridTanimla()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
  
            dataGridView1.Columns[0].HeaderText = "TC Kimlik No";
            dataGridView1.Columns[1].HeaderText = "Adı";
            dataGridView1.Columns[2].HeaderText = "Soyadı";
            dataGridView1.Columns[3].HeaderText = "Sınav 1";
            dataGridView1.Columns[4].HeaderText = "Sınav 2";
            dataGridView1.Columns[5].HeaderText = "Sınav 3";
            dataGridView1.Columns[6].HeaderText = "Ortalama";
            dataGridView1.Columns[7].HeaderText = "Geçme Durumu";
        }

        private void OgrencileriTanimla()
        {
            AppDbContext context_ = new AppDbContext();
            var ogrenciler_ = context_.Tbl_Student.ToList();
            var o_grenciler = new List<StudentDto>();
            foreach (var item in ogrenciler_)
            {
                o_grenciler.Add(new StudentDto
                {
                    Tckn = item.Tckn,
                    Name = item.Name,
                    Surname = item.Surname,
                    Exam_1 = item.Exam_1,
                    Exam_2 = item.Exam_2,
                    Exam_3 = item.Exam_3,
                    Average = item.Average,
                    State = item.State,
                });
            }

            dataGridView1.DataSource = o_grenciler;
            dataGridView1.Refresh();

            var ortalama = context_.Tbl_Student.Average(c => c.Average);
            ortalamaLbl.Text = ortalama.ToString("0.00");
        }

        private void listeBtn_Click(object sender, EventArgs e)
        {
            OgrenciListesi f1 = new OgrenciListesi();
            f1.Show();
            this.Hide();
        }

        private void notGirBtn_Click(object sender, EventArgs e)
        {
            var user = context.Tbl_Student.FirstOrDefault(c => c.Tckn == tcGirisTxt.Text.ToString());

            user.Exam_1 = short.Parse(sinav1GirisTxt.Text.ToString());
            user.Exam_2 = sinav2GirisTxt.Text.ToString() == null ? short.Parse(0.ToString()) : short.Parse(sinav2GirisTxt.Text.ToString());
            user.Exam_3 = sinav3GirisTxt.Text.ToString() == null ? short.Parse(0.ToString()) : short.Parse(sinav3GirisTxt.Text.ToString());

            user.Average = decimal.Parse((((double)user.Exam_1 * 0.15) + ((double)user.Exam_2 * 0.25) + ((double)user.Exam_3 * 0.60)).ToString());

            user.State = user.Average >= 45 ? true : false;

            context.SaveChanges();

            GridTanimla();
            OgrencileriTanimla();
            Temizle();
        }

        private void Temizle()
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Text = "";
                }
            }

            foreach (var item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Text = "";
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                var value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                var user = context.Tbl_Student.FirstOrDefault(c => c.Tckn == value);

                tcGuncelleTxt.Text = user.Tckn;
                sinav1GuncelleTxt.Text = user.Exam_1.ToString();
                sinav2GuncelleTxt.Text = user.Exam_2.ToString();
                sinav3GuncelleTxt.Text = user.Exam_3.ToString();
            }
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            var user = context.Tbl_Student.FirstOrDefault(c => c.Tckn == (tcGuncelleTxt.Text.ToString()));

            user.Exam_1 = short.Parse(sinav1GuncelleTxt.Text.ToString());
            user.Exam_2 = short.Parse(sinav2GuncelleTxt.Text.ToString());
            user.Exam_3 = short.Parse(sinav3GuncelleTxt.Text.ToString());
            user.Average = decimal.Parse((((double)user.Exam_1 * 0.15) + ((double)user.Exam_2 * 0.25) + ((double)user.Exam_3 * 0.60)).ToString());
            user.State = user.Average >= 45 ? true : false;

            context.SaveChanges();

            GridTanimla();
            OgrencileriTanimla();
            Temizle();
        }

        private void talepListesiBtn_Click(object sender, EventArgs e)
        {
            TalepListesiForm f1 = new TalepListesiForm();
            f1.Show();
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void ogrenciAraBtn_Click(object sender, EventArgs e)
        {
            OgrenciAraForm f1 = new OgrenciAraForm(this);
            f1.Show();
        }
    }
}
