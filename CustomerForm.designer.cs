
namespace WindowsFormsApp3
{
    partial class Customer_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CustomerAddressTB = new System.Windows.Forms.TextBox();
            this.CustomerPhoneTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CustomerNameTB = new System.Windows.Forms.TextBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerDG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.panel5.Location = new System.Drawing.Point(1432, 410);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(356, 10);
            this.panel5.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.panel4.Location = new System.Drawing.Point(973, 410);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 10);
            this.panel4.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.panel3.Location = new System.Drawing.Point(533, 410);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 10);
            this.panel3.TabIndex = 30;
            // 
            // CustomerAddressTB
            // 
            this.CustomerAddressTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CustomerAddressTB.Location = new System.Drawing.Point(1431, 369);
            this.CustomerAddressTB.Name = "CustomerAddressTB";
            this.CustomerAddressTB.Size = new System.Drawing.Size(357, 35);
            this.CustomerAddressTB.TabIndex = 34;
            // 
            // CustomerPhoneTB
            // 
            this.CustomerPhoneTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CustomerPhoneTB.Location = new System.Drawing.Point(973, 369);
            this.CustomerPhoneTB.Name = "CustomerPhoneTB";
            this.CustomerPhoneTB.Size = new System.Drawing.Size(324, 35);
            this.CustomerPhoneTB.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1423, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 48);
            this.label5.TabIndex = 26;
            this.label5.Text = "Customer Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(965, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 48);
            this.label4.TabIndex = 25;
            this.label4.Text = "Customer Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 48);
            this.label3.TabIndex = 24;
            this.label3.Text = "Customer Name";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1356, 530);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(206, 73);
            this.DeleteButton.TabIndex = 23;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(1041, 530);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(206, 73);
            this.UpdateButton.TabIndex = 22;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(712, 530);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(206, 73);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CustomerNameTB
            // 
            this.CustomerNameTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CustomerNameTB.Location = new System.Drawing.Point(533, 369);
            this.CustomerNameTB.Name = "CustomerNameTB";
            this.CustomerNameTB.Size = new System.Drawing.Size(278, 35);
            this.CustomerNameTB.TabIndex = 20;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CustomerLabel.Location = new System.Drawing.Point(1197, 50);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(222, 48);
            this.CustomerLabel.TabIndex = 19;
            this.CustomerLabel.Text = "Customers";
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel.Location = new System.Drawing.Point(805, 50);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(123, 48);
            this.ItemLabel.TabIndex = 18;
            this.ItemLabel.Text = "Items";
            this.ItemLabel.Click += new System.EventHandler(this.ItemLabel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.panel2.Location = new System.Drawing.Point(1203, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 10);
            this.panel2.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(1025, 629);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 48);
            this.label6.TabIndex = 35;
            this.label6.Text = "Customer List";
            // 
            // CustomerDG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CustomerDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDG.BackgroundColor = System.Drawing.Color.White;
            this.CustomerDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerDG.ColumnHeadersHeight = 47;
            this.CustomerDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.CustomerPhone,
            this.CustomerAdress});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerDG.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerDG.EnableHeadersVisualStyles = false;
            this.CustomerDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDG.Location = new System.Drawing.Point(89, 680);
            this.CustomerDG.Name = "CustomerDG";
            this.CustomerDG.RowHeadersVisible = false;
            this.CustomerDG.RowHeadersWidth = 92;
            this.CustomerDG.RowTemplate.Height = 37;
            this.CustomerDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerDG.Size = new System.Drawing.Size(2181, 545);
            this.CustomerDG.TabIndex = 36;
            this.CustomerDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerDG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustomerDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerDG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerDG.ThemeStyle.HeaderStyle.Height = 47;
            this.CustomerDG.ThemeStyle.ReadOnly = false;
            this.CustomerDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerDG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerDG.ThemeStyle.RowsStyle.Height = 37;
            this.CustomerDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDG_CellContentClick);
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.MinimumWidth = 11;
            this.CustomerID.Name = "CustomerID";
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 11;
            this.CustomerName.Name = "CustomerName";
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.HeaderText = "Customer Phone Number";
            this.CustomerPhone.MinimumWidth = 11;
            this.CustomerPhone.Name = "CustomerPhone";
            // 
            // CustomerAdress
            // 
            this.CustomerAdress.HeaderText = " Customer Adress";
            this.CustomerAdress.MinimumWidth = 11;
            this.CustomerAdress.Name = "CustomerAdress";
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2300, 1237);
            this.Controls.Add(this.CustomerDG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.CustomerAddressTB);
            this.Controls.Add(this.CustomerPhoneTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CustomerNameTB);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.ItemLabel);
            this.Name = "Customer_Form";
            this.Text = "Customer_Form";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox CustomerAddressTB;
        private System.Windows.Forms.TextBox CustomerPhoneTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox CustomerNameTB;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAdress;
    }
}