
namespace WindowsFormsApp3
{
    partial class Control_Panel_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.ItemNameTB = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.StockLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WeightTB = new System.Windows.Forms.TextBox();
            this.StockTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ItemListLabel = new System.Windows.Forms.Label();
            this.ItemListDG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ItemListDG)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel.Location = new System.Drawing.Point(807, 50);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(123, 48);
            this.ItemLabel.TabIndex = 0;
            this.ItemLabel.Text = "Items";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CustomerLabel.Location = new System.Drawing.Point(1197, 50);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(222, 48);
            this.CustomerLabel.TabIndex = 1;
            this.CustomerLabel.Text = "Customers";
            this.CustomerLabel.Click += new System.EventHandler(this.CustomerLabel_Click);
            // 
            // ItemNameTB
            // 
            this.ItemNameTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ItemNameTB.Location = new System.Drawing.Point(378, 368);
            this.ItemNameTB.Name = "ItemNameTB";
            this.ItemNameTB.Size = new System.Drawing.Size(278, 35);
            this.ItemNameTB.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(712, 530);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(206, 73);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(1042, 530);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(206, 73);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1357, 530);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(206, 73);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLabel.Location = new System.Drawing.Point(370, 299);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(224, 48);
            this.ItemNameLabel.TabIndex = 6;
            this.ItemNameLabel.Text = "Item Name";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(789, 299);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(151, 48);
            this.WeightLabel.TabIndex = 7;
            this.WeightLabel.Text = "Weight";
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLabel.Location = new System.Drawing.Point(1085, 299);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(125, 48);
            this.StockLabel.TabIndex = 8;
            this.StockLabel.Text = "Stock";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(1387, 299);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(116, 48);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.panel1.Location = new System.Drawing.Point(806, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 10);
            this.panel1.TabIndex = 11;
            // 
            // WeightTB
            // 
            this.WeightTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.WeightTB.Location = new System.Drawing.Point(797, 368);
            this.WeightTB.Name = "WeightTB";
            this.WeightTB.Size = new System.Drawing.Size(143, 35);
            this.WeightTB.TabIndex = 13;
            // 
            // StockTB
            // 
            this.StockTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StockTB.Location = new System.Drawing.Point(1069, 368);
            this.StockTB.Name = "StockTB";
            this.StockTB.Size = new System.Drawing.Size(170, 35);
            this.StockTB.TabIndex = 14;
            // 
            // PriceTB
            // 
            this.PriceTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PriceTB.Location = new System.Drawing.Point(1395, 368);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(108, 35);
            this.PriceTB.TabIndex = 15;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(1824, 243);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(230, 48);
            this.DescriptionLabel.TabIndex = 16;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DescriptionTB.Location = new System.Drawing.Point(1662, 312);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(570, 203);
            this.DescriptionTB.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.panel3.Location = new System.Drawing.Point(378, 409);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 10);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.panel4.Location = new System.Drawing.Point(797, 409);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(143, 10);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.panel5.Location = new System.Drawing.Point(1070, 409);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(169, 10);
            this.panel5.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.panel6.Location = new System.Drawing.Point(1395, 409);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(108, 10);
            this.panel6.TabIndex = 14;
            // 
            // ItemListLabel
            // 
            this.ItemListLabel.AutoSize = true;
            this.ItemListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ItemListLabel.Location = new System.Drawing.Point(1062, 631);
            this.ItemListLabel.Name = "ItemListLabel";
            this.ItemListLabel.Size = new System.Drawing.Size(179, 48);
            this.ItemListLabel.TabIndex = 18;
            this.ItemListLabel.Text = "Item List";
            // 
            // ItemListDG
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ItemListDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ItemListDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemListDG.BackgroundColor = System.Drawing.Color.White;
            this.ItemListDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemListDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemListDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemListDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ItemListDG.ColumnHeadersHeight = 47;
            this.ItemListDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.ItemWeight,
            this.ItemStock,
            this.ItemPrice,
            this.ItemDescription});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemListDG.DefaultCellStyle = dataGridViewCellStyle9;
            this.ItemListDG.EnableHeadersVisualStyles = false;
            this.ItemListDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemListDG.Location = new System.Drawing.Point(119, 694);
            this.ItemListDG.Name = "ItemListDG";
            this.ItemListDG.RowHeadersVisible = false;
            this.ItemListDG.RowHeadersWidth = 92;
            this.ItemListDG.RowTemplate.Height = 37;
            this.ItemListDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemListDG.Size = new System.Drawing.Size(2066, 506);
            this.ItemListDG.TabIndex = 19;
            this.ItemListDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemListDG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ItemListDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ItemListDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ItemListDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ItemListDG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ItemListDG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemListDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ItemListDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItemListDG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ItemListDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ItemListDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ItemListDG.ThemeStyle.HeaderStyle.Height = 47;
            this.ItemListDG.ThemeStyle.ReadOnly = false;
            this.ItemListDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemListDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemListDG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ItemListDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemListDG.ThemeStyle.RowsStyle.Height = 37;
            this.ItemListDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemListDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemListDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemListDG_CellContentClick);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.MinimumWidth = 11;
            this.ItemID.Name = "ItemID";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 11;
            this.ItemName.Name = "ItemName";
            // 
            // ItemWeight
            // 
            this.ItemWeight.HeaderText = "Item Weight";
            this.ItemWeight.MinimumWidth = 11;
            this.ItemWeight.Name = "ItemWeight";
            // 
            // ItemStock
            // 
            this.ItemStock.HeaderText = "ItemStock";
            this.ItemStock.MinimumWidth = 11;
            this.ItemStock.Name = "ItemStock";
            // 
            // ItemPrice
            // 
            this.ItemPrice.HeaderText = "Item Price";
            this.ItemPrice.MinimumWidth = 11;
            this.ItemPrice.Name = "ItemPrice";
            // 
            // ItemDescription
            // 
            this.ItemDescription.HeaderText = "Item Description";
            this.ItemDescription.MinimumWidth = 11;
            this.ItemDescription.Name = "ItemDescription";
            // 
            // Control_Panel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(2301, 1236);
            this.Controls.Add(this.ItemListDG);
            this.Controls.Add(this.ItemListLabel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.StockTB);
            this.Controls.Add(this.WeightTB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ItemNameTB);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.ItemLabel);
            this.Name = "Control_Panel_Form";
            this.Text = "Control_Panel_Form";
            ((System.ComponentModel.ISupportInitialize)(this.ItemListDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.TextBox ItemNameTB;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox WeightTB;
        private System.Windows.Forms.TextBox StockTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label ItemListLabel;
        private Guna.UI2.WinForms.Guna2DataGridView ItemListDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
    }
}