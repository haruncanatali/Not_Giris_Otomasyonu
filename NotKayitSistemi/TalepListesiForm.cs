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
    public partial class TalepListesiForm : Form
    {
        AppDbContext context = new AppDbContext();
        public TalepListesiForm()
        {
            InitializeComponent();
        }

        private void TalepListesiForm_Load(object sender, EventArgs e)
        {
            talepSayisiLbl.Text = context.Tbl_Request.Count().ToString();

            flowDoldur();
        }

        private void flowDoldur()
        {
            var requests = context.Tbl_Request.ToList();
            foreach (var item in requests)
            {
                Button button = new Button();

                button.Width = 100;
                button.Height = 100;
                button.Margin = new Padding(0, -1, -1, -1);

                button.Text = item.Name + " " + item.Surname + " " + item.Tckn;
                button.Tag = item.Id;

                flowLayoutPanel1.Controls.Add(button);

                button.Click += new EventHandler(btn_Click);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TalepDetay f1 = new TalepDetay(this);
            f1.requestId = int.Parse(btn.Tag.ToString());
            f1.Show();
        }
    }
}
