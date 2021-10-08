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
    public partial class OgrenciListesi : Form
    {
        AppDbContext context = new AppDbContext();
        List<ListeDbo> liste = new List<ListeDbo>();
        public OgrenciListesi()
        {
            InitializeComponent();
        }

        private void OgrenciListesi_Load(object sender, EventArgs e)
        {
            foreach (var item in context.Tbl_Student.ToList())
            {
                liste.Add(new ListeDbo
                {
                    NameAndSurname = item.Name+" "+item.Surname,
                    Tckn = item.Tckn
                });
            }

            foreach (var item in liste)
            {
                listeLbx.Items.Add(item.NameAndSurname + "," + item.Tckn);
            }
        }

        private void secBtn_Click(object sender, EventArgs e)
        {
            string value = listeLbx.Items[listeLbx.SelectedIndex].ToString().Split(',').ToArray()[1].ToString();
            var user = context.Tbl_Student.FirstOrDefault(c=>c.Tckn == value);
            if (user!=null)
            {
                EgitmenForm f1 = new EgitmenForm();
                f1.tcGirisTxt.Text = user.Tckn;
                f1.sinav1GirisTxt.Text = user.Exam_1.ToString();
                f1.sinav2GirisTxt.Text = user.Exam_2.ToString();
                f1.sinav3GirisTxt.Text = user.Exam_3.ToString();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class ListeDbo
    {
        public string NameAndSurname { get; set; }
        public string Tckn { get; set; }
    }
}
