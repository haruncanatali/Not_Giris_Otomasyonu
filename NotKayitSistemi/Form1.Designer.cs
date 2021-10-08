
namespace NotKayitSistemi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tcTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.egitmenChck = new System.Windows.Forms.CheckBox();
            this.ogrenciChck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kayitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(176, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "TC Kimlik No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(89, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Şifre :";
            // 
            // tcTxt
            // 
            this.tcTxt.Location = new System.Drawing.Point(152, 117);
            this.tcTxt.MaxLength = 11;
            this.tcTxt.Name = "tcTxt";
            this.tcTxt.Size = new System.Drawing.Size(200, 20);
            this.tcTxt.TabIndex = 1;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(152, 153);
            this.sifreTxt.MaxLength = 8;
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(200, 20);
            this.sifreTxt.TabIndex = 2;
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(219, 236);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(75, 23);
            this.girisBtn.TabIndex = 3;
            this.girisBtn.Text = "Giriş";
            this.girisBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.Location = new System.Drawing.Point(300, 236);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(76, 23);
            this.cikisBtn.TabIndex = 4;
            this.cikisBtn.Text = "Çıkış";
            this.cikisBtn.UseVisualStyleBackColor = true;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // egitmenChck
            // 
            this.egitmenChck.AutoSize = true;
            this.egitmenChck.Location = new System.Drawing.Point(152, 197);
            this.egitmenChck.Name = "egitmenChck";
            this.egitmenChck.Size = new System.Drawing.Size(64, 17);
            this.egitmenChck.TabIndex = 6;
            this.egitmenChck.Text = "Eğitmen";
            this.egitmenChck.UseVisualStyleBackColor = true;
            // 
            // ogrenciChck
            // 
            this.ogrenciChck.AutoSize = true;
            this.ogrenciChck.Location = new System.Drawing.Point(231, 197);
            this.ogrenciChck.Name = "ogrenciChck";
            this.ogrenciChck.Size = new System.Drawing.Size(63, 17);
            this.ogrenciChck.TabIndex = 6;
            this.ogrenciChck.Text = "Öğrenci";
            this.ogrenciChck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(256, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifremi Unuttum ?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // kayitBtn
            // 
            this.kayitBtn.Location = new System.Drawing.Point(138, 236);
            this.kayitBtn.Name = "kayitBtn";
            this.kayitBtn.Size = new System.Drawing.Size(75, 23);
            this.kayitBtn.TabIndex = 8;
            this.kayitBtn.Text = "Kayıt";
            this.kayitBtn.UseVisualStyleBackColor = true;
            this.kayitBtn.Click += new System.EventHandler(this.kayitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(418, 271);
            this.Controls.Add(this.kayitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ogrenciChck);
            this.Controls.Add(this.egitmenChck);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.tcTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Formu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tcTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox egitmenChck;
        private System.Windows.Forms.CheckBox ogrenciChck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button kayitBtn;
    }
}

