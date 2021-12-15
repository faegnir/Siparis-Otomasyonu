
namespace Sipariş_Otomasyonu
{
    partial class LoginForm
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
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdLogin = new System.Windows.Forms.TextBox();
            this.txtSifreLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(246, 207);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(75, 23);
            this.btnKayitOl.TabIndex = 0;
            this.btnKayitOl.Text = "KAYIT OL";
            this.btnKayitOl.UseMnemonic = false;
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(165, 207);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseMnemonic = false;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "KULLANICI ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ŞİFRE :";
            // 
            // txtKullaniciAdLogin
            // 
            this.txtKullaniciAdLogin.Location = new System.Drawing.Point(165, 86);
            this.txtKullaniciAdLogin.Name = "txtKullaniciAdLogin";
            this.txtKullaniciAdLogin.Size = new System.Drawing.Size(156, 20);
            this.txtKullaniciAdLogin.TabIndex = 4;
            // 
            // txtSifreLogin
            // 
            this.txtSifreLogin.Location = new System.Drawing.Point(165, 156);
            this.txtSifreLogin.Name = "txtSifreLogin";
            this.txtSifreLogin.PasswordChar = '*';
            this.txtSifreLogin.Size = new System.Drawing.Size(156, 20);
            this.txtSifreLogin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(174, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "HOŞ GELDİNİZ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifreLogin);
            this.Controls.Add(this.txtKullaniciAdLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnKayitOl);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Otomasyonu";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdLogin;
        private System.Windows.Forms.TextBox txtSifreLogin;
        private System.Windows.Forms.Label label3;
    }
}