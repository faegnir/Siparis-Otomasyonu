
namespace Sipariş_Otomasyonu
{
    partial class creditpaymentform
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
            this.cardno_txbox = new System.Windows.Forms.TextBox();
            this.mm_txbox = new System.Windows.Forms.TextBox();
            this.cvv_txbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.yy_txbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cardname_txbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expiration Date (MM/YY)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CVV";
            // 
            // cardno_txbox
            // 
            this.cardno_txbox.Location = new System.Drawing.Point(163, 63);
            this.cardno_txbox.MaxLength = 16;
            this.cardno_txbox.Name = "cardno_txbox";
            this.cardno_txbox.Size = new System.Drawing.Size(159, 22);
            this.cardno_txbox.TabIndex = 4;
            // 
            // mm_txbox
            // 
            this.mm_txbox.Location = new System.Drawing.Point(204, 103);
            this.mm_txbox.MaxLength = 2;
            this.mm_txbox.Name = "mm_txbox";
            this.mm_txbox.Size = new System.Drawing.Size(24, 22);
            this.mm_txbox.TabIndex = 5;
            // 
            // cvv_txbox
            // 
            this.cvv_txbox.Location = new System.Drawing.Point(163, 141);
            this.cvv_txbox.MaxLength = 3;
            this.cvv_txbox.Name = "cvv_txbox";
            this.cvv_txbox.Size = new System.Drawing.Size(65, 22);
            this.cvv_txbox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(163, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(39, 190);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(133, 21);
            this.checkBox.TabIndex = 8;
            this.checkBox.Text = "I agree to terms.";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // yy_txbox
            // 
            this.yy_txbox.Location = new System.Drawing.Point(252, 103);
            this.yy_txbox.MaxLength = 2;
            this.yy_txbox.Name = "yy_txbox";
            this.yy_txbox.Size = new System.Drawing.Size(25, 22);
            this.yy_txbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name on Card";
            // 
            // cardname_txbox
            // 
            this.cardname_txbox.Location = new System.Drawing.Point(163, 26);
            this.cardname_txbox.Name = "cardname_txbox";
            this.cardname_txbox.Size = new System.Drawing.Size(114, 22);
            this.cardname_txbox.TabIndex = 3;
            // 
            // creditpaymentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 339);
            this.Controls.Add(this.cardname_txbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yy_txbox);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cvv_txbox);
            this.Controls.Add(this.mm_txbox);
            this.Controls.Add(this.cardno_txbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "creditpaymentform";
            this.Text = "creditpaymentform";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.creditpaymentform_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cardno_txbox;
        private System.Windows.Forms.TextBox mm_txbox;
        private System.Windows.Forms.TextBox cvv_txbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox yy_txbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cardname_txbox;
    }
}