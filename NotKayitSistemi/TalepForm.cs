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
    public partial class TalepForm : Form
    {
        public Student user = null;
        AppDbContext context = new AppDbContext();
        public TalepForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (talepNedenCbx.Text.ToString() != null && aciklamaTxt.Text.ToString() != null)
            {
                try
                {
                    context.Tbl_Request.Add(new Request
                    {
                        Name = user.Name,
                        Surname = user.Surname,
                        Tckn = user.Tckn,
                        Reason = talepNedenCbx.Text.ToString(),
                        Description = aciklamaTxt.Text.ToString(),
                        Date = DateTime.UtcNow
                    });

                    context.SaveChanges();

                    MessageBox.Show("Talebiniz İletildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    talepNedenCbx.Text = null;
                    aciklamaTxt.Text = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Talebiniz iletilemedi. Lütfen daha sonra tekrar deneyiniz. Hata:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
