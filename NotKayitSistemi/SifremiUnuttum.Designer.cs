
namespace NotKayitSistemi
{
    partial class SifremiUnuttum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tcTxt = new System.Windows.Forms.TextBox();
            this.soruTxt = new System.Windows.Forms.TextBox();
            this.cevapTxt = new System.Windows.Forms.TextBox();
            this.ogrenciChck = new System.Windows.Forms.CheckBox();
            this.egitmenChck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.degistirBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gizli Sorunuz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cevabınız :";
            // 
            // tcTxt
            // 
            this.tcTxt.Location = new System.Drawing.Point(119, 62);
            this.tcTxt.MaxLength = 11;
            this.tcTxt.Name = "tcTxt";
            this.tcTxt.Size = new System.Drawing.Size(162, 20);
            this.tcTxt.TabIndex = 3;
            this.tcTxt.TextChanged += new System.EventHandler(this.tcTxt_TextChanged);
            // 
            // soruTxt
            // 
            this.soruTxt.Location = new System.Drawing.Point(119, 94);
            this.soruTxt.Name = "soruTxt";
            this.soruTxt.ReadOnly = true;
            this.soruTxt.Size = new System.Drawing.Size(162, 20);
            this.soruTxt.TabIndex = 4;
            // 
            // cevapTxt
            // 
            this.cevapTxt.Location = new System.Drawing.Point(119, 128);
            this.cevapTxt.Name = "cevapTxt";
            this.cevapTxt.Size = new System.Drawing.Size(162, 20);
            this.cevapTxt.TabIndex = 5;
            // 
            // ogrenciChck
            // 
            this.ogrenciChck.AutoSize = true;
            this.ogrenciChck.Location = new System.Drawing.Point(119, 30);
            this.ogrenciChck.Name = "ogrenciChck";
            this.ogrenciChck.Size = new System.Drawing.Size(63, 17);
            this.ogrenciChck.TabIndex = 6;
            this.ogrenciChck.Text = "Öğrenci";
            this.ogrenciChck.UseVisualStyleBackColor = true;
            // 
            // egitmenChck
            // 
            this.egitmenChck.AutoSize = true;
            this.egitmenChck.Location = new System.Drawing.Point(188, 30);
            this.egitmenChck.Name = "egitmenChck";
            this.egitmenChck.Size = new System.Drawing.Size(64, 17);
            this.egitmenChck.TabIndex = 7;
            this.egitmenChck.Text = "Eğitmen";
            this.egitmenChck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(41, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pozisyon :";
            // 
            // degistirBtn
            // 
            this.degistirBtn.Location = new System.Drawing.Point(168, 202);
            this.degistirBtn.Name = "degistirBtn";
            this.degistirBtn.Size = new System.Drawing.Size(75, 23);
            this.degistirBtn.TabIndex = 9;
            this.degistirBtn.Text = "Değiştir";
            this.degistirBtn.UseVisualStyleBackColor = true;
            this.degistirBtn.Click += new System.EventHandler(this.degistirBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Yeni Şifreniz :";
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(119, 164);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(162, 20);
            this.sifreTxt.TabIndex = 11;
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 256);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.degistirBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.egitmenChck);
            this.Controls.Add(this.ogrenciChck);
            this.Controls.Add(this.cevapTxt);
            this.Controls.Add(this.soruTxt);
            this.Controls.Add(this.tcTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Yenileme Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tcTxt;
        private System.Windows.Forms.TextBox soruTxt;
        private System.Windows.Forms.TextBox cevapTxt;
        private System.Windows.Forms.CheckBox ogrenciChck;
        private System.Windows.Forms.CheckBox egitmenChck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button degistirBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sifreTxt;
    }
}