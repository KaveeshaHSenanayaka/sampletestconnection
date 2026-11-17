namespace sampletestconnection
{
    partial class Transactionfrom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ComboTransaction = new System.Windows.Forms.ComboBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtSearchitem = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.dgvTransaction = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboTransaction
            // 
            this.ComboTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTransaction.FormattingEnabled = true;
            this.ComboTransaction.Location = new System.Drawing.Point(227, 52);
            this.ComboTransaction.Name = "ComboTransaction";
            this.ComboTransaction.Size = new System.Drawing.Size(186, 24);
            this.ComboTransaction.TabIndex = 28;
            this.ComboTransaction.SelectedIndexChanged += new System.EventHandler(this.ComboTransaction_SelectedIndexChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(657, 55);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(196, 24);
            this.txtItemName.TabIndex = 30;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(74)))));
            this.lblSearch.Location = new System.Drawing.Point(12, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(187, 21);
            this.lblSearch.TabIndex = 33;
            this.lblSearch.Text = "Search Item to Transact";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(74)))));
            this.lblItemName.Location = new System.Drawing.Point(507, 52);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(99, 21);
            this.lblItemName.TabIndex = 35;
            this.lblItemName.Text = " Item Name";
            this.lblItemName.Click += new System.EventHandler(this.lblItemName_Click);
            // 
            // txtSearchitem
            // 
            this.txtSearchitem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchitem.Location = new System.Drawing.Point(227, 12);
            this.txtSearchitem.Multiline = true;
            this.txtSearchitem.Name = "txtSearchitem";
            this.txtSearchitem.Size = new System.Drawing.Size(186, 24);
            this.txtSearchitem.TabIndex = 40;
            this.txtSearchitem.TextChanged += new System.EventHandler(this.TxtSearchitem_TextChanged);
            // 
            // txtItemID
            // 
            this.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(657, 16);
            this.txtItemID.Multiline = true;
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(196, 24);
            this.txtItemID.TabIndex = 32;
            this.txtItemID.TextChanged += new System.EventHandler(this.txtItemID_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(657, 91);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(196, 24);
            this.txtQuantity.TabIndex = 31;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(74)))));
            this.lblTransactionType.Location = new System.Drawing.Point(12, 51);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(138, 21);
            this.lblTransactionType.TabIndex = 37;
            this.lblTransactionType.Text = "Transaction Type";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(74)))));
            this.lblQty.Location = new System.Drawing.Point(510, 11);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(66, 21);
            this.lblQty.TabIndex = 38;
            this.lblQty.Text = "Item ID";
            this.lblQty.Click += new System.EventHandler(this.lblQty_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(74)))));
            this.lblSize.Location = new System.Drawing.Point(510, 92);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(126, 21);
            this.lblSize.TabIndex = 39;
            this.lblSize.Text = "Initial Quantity";
            this.lblSize.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // dgvTransaction
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTransaction.ColumnHeadersHeight = 4;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransaction.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransaction.Location = new System.Drawing.Point(41, 186);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.RowHeadersVisible = false;
            this.dgvTransaction.Size = new System.Drawing.Size(885, 282);
            this.dgvTransaction.TabIndex = 41;
            this.dgvTransaction.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransaction.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTransaction.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTransaction.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTransaction.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTransaction.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransaction.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransaction.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTransaction.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransaction.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransaction.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTransaction.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTransaction.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTransaction.ThemeStyle.ReadOnly = false;
            this.dgvTransaction.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransaction.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransaction.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransaction.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTransaction.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTransaction.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransaction.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTransaction_CellContentClick);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))), ((int)(((byte)(74)))));
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))), ((int)(((byte)(74)))));
            this.btnTransaction.Location = new System.Drawing.Point(-1, 129);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(980, 36);
            this.btnTransaction.TabIndex = 42;
            this.btnTransaction.Text = "Click Here To Transaction ....!";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.BtnTransaction_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProjectName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectName.Location = new System.Drawing.Point(227, 89);
            this.txtProjectName.Multiline = true;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(186, 24);
            this.txtProjectName.TabIndex = 43;
            this.txtProjectName.TextChanged += new System.EventHandler(this.txtProjectName_TextChanged);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(74)))));
            this.lblProjectName.Location = new System.Drawing.Point(12, 90);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(158, 21);
            this.lblProjectName.TabIndex = 44;
            this.lblProjectName.Text = "Enter Project Name";
            this.lblProjectName.Click += new System.EventHandler(this.lblProjectName_Click);
            // 
            // Transactionfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(980, 547);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.ComboTransaction);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtSearchitem);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblTransactionType);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transactionfrom";
            this.Text = "Transactionfrom";
            this.Load += new System.EventHandler(this.Transactionfrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboTransaction;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtSearchitem;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblSize;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTransaction;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lblProjectName;
    }
}