
namespace Sipariş_Otomasyonu
{
    partial class PaymentForm
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
            this.credit_button = new System.Windows.Forms.Button();
            this.cash_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Options";
            // 
            // credit_button
            // 
            this.credit_button.Location = new System.Drawing.Point(27, 154);
            this.credit_button.Name = "credit_button";
            this.credit_button.Size = new System.Drawing.Size(84, 30);
            this.credit_button.TabIndex = 1;
            this.credit_button.Text = "Credit";
            this.credit_button.UseVisualStyleBackColor = true;
            this.credit_button.Click += new System.EventHandler(this.credit_button_Click);
            // 
            // cash_button
            // 
            this.cash_button.Location = new System.Drawing.Point(150, 154);
            this.cash_button.Name = "cash_button";
            this.cash_button.Size = new System.Drawing.Size(130, 30);
            this.cash_button.TabIndex = 2;
            this.cash_button.Text = "Cash on Delivery";
            this.cash_button.UseVisualStyleBackColor = true;
            this.cash_button.Click += new System.EventHandler(this.cash_button_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 339);
            this.Controls.Add(this.cash_button);
            this.Controls.Add(this.credit_button);
            this.Controls.Add(this.label1);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button credit_button;
        private System.Windows.Forms.Button cash_button;
    }
}