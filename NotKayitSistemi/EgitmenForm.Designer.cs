
namespace NotKayitSistemi
{
    partial class EgitmenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ogrenciAraBtn = new System.Windows.Forms.Button();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.ortalamaLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sinav3GuncelleTxt = new System.Windows.Forms.TextBox();
            this.sinav2GuncelleTxt = new System.Windows.Forms.TextBox();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.sinav1GuncelleTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tcGuncelleTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listeBtn = new System.Windows.Forms.Button();
            this.sinav3GirisTxt = new System.Windows.Forms.TextBox();
            this.sinav2GirisTxt = new System.Windows.Forms.TextBox();
            this.sinav1GirisTxt = new System.Windows.Forms.TextBox();
            this.tcGirisTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notGirBtn = new System.Windows.Forms.Button();
            this.talepListesiBtn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1084, 272);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilgi Kısmı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 253);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.ogrenciAraBtn);
            this.groupBox1.Controls.Add(this.cikisBtn);
            this.groupBox1.Controls.Add(this.ortalamaLbl);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.talepListesiBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1108, 261);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Kısmı";
            // 
            // ogrenciAraBtn
            // 
            this.ogrenciAraBtn.Location = new System.Drawing.Point(512, 181);
            this.ogrenciAraBtn.Name = "ogrenciAraBtn";
            this.ogrenciAraBtn.Size = new System.Drawing.Size(101, 30);
            this.ogrenciAraBtn.TabIndex = 14;
            this.ogrenciAraBtn.Text = "Öğrenci Ara";
            this.ogrenciAraBtn.UseVisualStyleBackColor = true;
            this.ogrenciAraBtn.Click += new System.EventHandler(this.ogrenciAraBtn_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.Location = new System.Drawing.Point(512, 217);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(101, 30);
            this.cikisBtn.TabIndex = 13;
            this.cikisBtn.Text = "Sistemden Çık";
            this.cikisBtn.UseVisualStyleBackColor = true;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // ortalamaLbl
            // 
            this.ortalamaLbl.AutoSize = true;
            this.ortalamaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ortalamaLbl.Location = new System.Drawing.Point(528, 91);
            this.ortalamaLbl.Name = "ortalamaLbl";
            this.ortalamaLbl.Size = new System.Drawing.Size(33, 20);
            this.ortalamaLbl.TabIndex = 12;
            this.ortalamaLbl.Text = "null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(491, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Sınıf Ortalaması";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Linen;
            this.groupBox2.Controls.Add(this.sinav3GuncelleTxt);
            this.groupBox2.Controls.Add(this.sinav2GuncelleTxt);
            this.groupBox2.Controls.Add(this.guncelleBtn);
            this.groupBox2.Controls.Add(this.sinav1GuncelleTxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tcGuncelleTxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(656, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 232);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Not Güncelle";
            // 
            // sinav3GuncelleTxt
            // 
            this.sinav3GuncelleTxt.Location = new System.Drawing.Point(216, 131);
            this.sinav3GuncelleTxt.Name = "sinav3GuncelleTxt";
            this.sinav3GuncelleTxt.Size = new System.Drawing.Size(201, 20);
            this.sinav3GuncelleTxt.TabIndex = 15;
            // 
            // sinav2GuncelleTxt
            // 
            this.sinav2GuncelleTxt.Location = new System.Drawing.Point(216, 100);
            this.sinav2GuncelleTxt.Name = "sinav2GuncelleTxt";
            this.sinav2GuncelleTxt.Size = new System.Drawing.Size(201, 20);
            this.sinav2GuncelleTxt.TabIndex = 14;
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(267, 157);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(101, 44);
            this.guncelleBtn.TabIndex = 7;
            this.guncelleBtn.Text = "Not Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // sinav1GuncelleTxt
            // 
            this.sinav1GuncelleTxt.Location = new System.Drawing.Point(216, 65);
            this.sinav1GuncelleTxt.Name = "sinav1GuncelleTxt";
            this.sinav1GuncelleTxt.Size = new System.Drawing.Size(201, 20);
            this.sinav1GuncelleTxt.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(91, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "TC Kimlik No :";
            // 
            // tcGuncelleTxt
            // 
            this.tcGuncelleTxt.Location = new System.Drawing.Point(216, 32);
            this.tcGuncelleTxt.Name = "tcGuncelleTxt";
            this.tcGuncelleTxt.Size = new System.Drawing.Size(201, 20);
            this.tcGuncelleTxt.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(132, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sınav 1 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(132, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sınav 3 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(132, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sınav 2 :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox4.Controls.Add(this.listeBtn);
            this.groupBox4.Controls.Add(this.sinav3GirisTxt);
            this.groupBox4.Controls.Add(this.sinav2GirisTxt);
            this.groupBox4.Controls.Add(this.sinav1GirisTxt);
            this.groupBox4.Controls.Add(this.tcGirisTxt);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.notGirBtn);
            this.groupBox4.Location = new System.Drawing.Point(12, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 232);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Not Giriş";
            // 
            // listeBtn
            // 
            this.listeBtn.BackColor = System.Drawing.Color.LightGreen;
            this.listeBtn.Location = new System.Drawing.Point(339, 32);
            this.listeBtn.Name = "listeBtn";
            this.listeBtn.Size = new System.Drawing.Size(49, 20);
            this.listeBtn.TabIndex = 7;
            this.listeBtn.Text = "Liste";
            this.listeBtn.UseVisualStyleBackColor = false;
            this.listeBtn.Click += new System.EventHandler(this.listeBtn_Click);
            // 
            // sinav3GirisTxt
            // 
            this.sinav3GirisTxt.Location = new System.Drawing.Point(131, 131);
            this.sinav3GirisTxt.Name = "sinav3GirisTxt";
            this.sinav3GirisTxt.Size = new System.Drawing.Size(201, 20);
            this.sinav3GirisTxt.TabIndex = 6;
            // 
            // sinav2GirisTxt
            // 
            this.sinav2GirisTxt.Location = new System.Drawing.Point(131, 100);
            this.sinav2GirisTxt.Name = "sinav2GirisTxt";
            this.sinav2GirisTxt.Size = new System.Drawing.Size(201, 20);
            this.sinav2GirisTxt.TabIndex = 5;
            // 
            // sinav1GirisTxt
            // 
            this.sinav1GirisTxt.Location = new System.Drawing.Point(131, 65);
            this.sinav1GirisTxt.Name = "sinav1GirisTxt";
            this.sinav1GirisTxt.Size = new System.Drawing.Size(201, 20);
            this.sinav1GirisTxt.TabIndex = 4;
            // 
            // tcGirisTxt
            // 
            this.tcGirisTxt.Location = new System.Drawing.Point(131, 32);
            this.tcGirisTxt.Name = "tcGirisTxt";
            this.tcGirisTxt.Size = new System.Drawing.Size(201, 20);
            this.tcGirisTxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(47, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sınav 3 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(47, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sınav 2 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(47, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sınav 1 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC Kimlik No :";
            // 
            // notGirBtn
            // 
            this.notGirBtn.Location = new System.Drawing.Point(182, 157);
            this.notGirBtn.Name = "notGirBtn";
            this.notGirBtn.Size = new System.Drawing.Size(101, 44);
            this.notGirBtn.TabIndex = 0;
            this.notGirBtn.Text = "Not Giriş";
            this.notGirBtn.UseVisualStyleBackColor = true;
            this.notGirBtn.Click += new System.EventHandler(this.notGirBtn_Click);
            // 
            // talepListesiBtn
            // 
            this.talepListesiBtn.Location = new System.Drawing.Point(512, 145);
            this.talepListesiBtn.Name = "talepListesiBtn";
            this.talepListesiBtn.Size = new System.Drawing.Size(101, 30);
            this.talepListesiBtn.TabIndex = 1;
            this.talepListesiBtn.Text = "Talep Listesi";
            this.talepListesiBtn.UseVisualStyleBackColor = true;
            this.talepListesiBtn.Click += new System.EventHandler(this.talepListesiBtn_Click);
            // 
            // EgitmenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EgitmenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eğitmen Formu";
            this.Load += new System.EventHandler(this.EgitmenForm_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button talepListesiBtn;
        private System.Windows.Forms.Button notGirBtn;
        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.Label ortalamaLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ogrenciAraBtn;
        private System.Windows.Forms.Button listeBtn;
        public System.Windows.Forms.TextBox tcGirisTxt;
        public System.Windows.Forms.TextBox sinav3GirisTxt;
        public System.Windows.Forms.TextBox sinav2GirisTxt;
        public System.Windows.Forms.TextBox sinav1GirisTxt;
        public System.Windows.Forms.TextBox sinav3GuncelleTxt;
        public System.Windows.Forms.TextBox sinav2GuncelleTxt;
        public System.Windows.Forms.TextBox sinav1GuncelleTxt;
        public System.Windows.Forms.TextBox tcGuncelleTxt;
    }
}