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
    public partial class TalepDetay : Form
    {
        public int requestId = 0;
        AppDbContext context = new AppDbContext();
        Request request = new Request();
        TalepListesiForm f1 = new TalepListesiForm();
        public TalepDetay(TalepListesiForm f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void TalepDetay_Load(object sender, EventArgs e)
        {
            request = context.Tbl_Request.FirstOrDefault(c => c.Id == requestId);

            tcLbl.Text = request.Tckn;
            adLbl.Text = request.Name;
            soyadLbl.Text = request.Surname;
            talepNedenLbl.Text = request.Reason;
            talepTarihiLbl.Text = request.Date.ToString();
            talepTxt.Text = request.Description;
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Talebin okunup onaylandığı kabul edilip silinecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    context.Tbl_Request.Remove(request);
                    context.SaveChanges();
                    MessageBox.Show("Talebin silinmesi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Button butn = new Button();
                    foreach (var item in f1.flowLayoutPanel1.Controls)
                    {
                        if (item is Button)
                        {
                            Button btn = item as Button;
                            if (btn.Tag.ToString() == requestId.ToString())
                            {
                                butn = btn;
                            }
                        }
                    }

                    f1.flowLayoutPanel1.Controls.Remove(butn);
                    f1.talepSayisiLbl.Text = ((int.Parse(f1.talepSayisiLbl.Text.ToString())) - 1).ToString();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Talebin silinmesi sırasında hata meydana geldi. Lütfen daha sonra tekrar deneyiniz. Hata:" + ex.Message,"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tcLbl.Text.ToString());
            MessageBox.Show("Kopyalama başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
