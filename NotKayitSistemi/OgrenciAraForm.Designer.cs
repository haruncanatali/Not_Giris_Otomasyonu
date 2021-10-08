
namespace NotKayitSistemi
{
    partial class OgrenciAraForm
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
            this.tcNoTxt = new System.Windows.Forms.TextBox();
            this.bulunduChck = new System.Windows.Forms.CheckBox();
            this.bulunamadıChck = new System.Windows.Forms.CheckBox();
            this.ogrenciSecBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik Numarası :";
            // 
            // tcNoTxt
            // 
            this.tcNoTxt.Location = new System.Drawing.Point(123, 10);
            this.tcNoTxt.MaxLength = 11;
            this.tcNoTxt.Name = "tcNoTxt";
            this.tcNoTxt.Size = new System.Drawing.Size(152, 20);
            this.tcNoTxt.TabIndex = 1;
            this.tcNoTxt.TextChanged += new System.EventHandler(this.tcNoTxt_TextChanged);
            // 
            // bulunduChck
            // 
            this.bulunduChck.AutoSize = true;
            this.bulunduChck.Enabled = false;
            this.bulunduChck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bulunduChck.Location = new System.Drawing.Point(123, 37);
            this.bulunduChck.Name = "bulunduChck";
            this.bulunduChck.Size = new System.Drawing.Size(72, 17);
            this.bulunduChck.TabIndex = 2;
            this.bulunduChck.Text = "Bulundu";
            this.bulunduChck.UseVisualStyleBackColor = true;
            // 
            // bulunamadıChck
            // 
            this.bulunamadıChck.AutoSize = true;
            this.bulunamadıChck.Enabled = false;
            this.bulunamadıChck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bulunamadıChck.Location = new System.Drawing.Point(191, 37);
            this.bulunamadıChck.Name = "bulunamadıChck";
            this.bulunamadıChck.Size = new System.Drawing.Size(91, 17);
            this.bulunamadıChck.TabIndex = 2;
            this.bulunamadıChck.Text = "Bulunamadı";
            this.bulunamadıChck.UseVisualStyleBackColor = true;
            // 
            // ogrenciSecBtn
            // 
            this.ogrenciSecBtn.Location = new System.Drawing.Point(281, 7);
            this.ogrenciSecBtn.Name = "ogrenciSecBtn";
            this.ogrenciSecBtn.Size = new System.Drawing.Size(75, 49);
            this.ogrenciSecBtn.TabIndex = 3;
            this.ogrenciSecBtn.Text = "Öğrenciyi Seç";
            this.ogrenciSecBtn.UseVisualStyleBackColor = true;
            this.ogrenciSecBtn.Click += new System.EventHandler(this.ogrenciSecBtn_Click);
            // 
            // OgrenciAraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 68);
            this.Controls.Add(this.ogrenciSecBtn);
            this.Controls.Add(this.bulunamadıChck);
            this.Controls.Add(this.bulunduChck);
            this.Controls.Add(this.tcNoTxt);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciAraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Arama Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tcNoTxt;
        private System.Windows.Forms.CheckBox bulunduChck;
        private System.Windows.Forms.CheckBox bulunamadıChck;
        private System.Windows.Forms.Button ogrenciSecBtn;
    }
}