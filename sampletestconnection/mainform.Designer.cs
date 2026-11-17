namespace sampletestconnection
{
    partial class mainform
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
            this.Toppanel = new System.Windows.Forms.Panel();
            this.btnoppanel = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnpaid = new System.Windows.Forms.Button();
            this.btntrans = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnstavailable = new System.Windows.Forms.Button();
            this.Centerpanel = new System.Windows.Forms.Panel();
            this.Toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(74)))));
            this.Toppanel.Controls.Add(this.btnoppanel);
            this.Toppanel.Controls.Add(this.btnexit);
            this.Toppanel.Controls.Add(this.btnpaid);
            this.Toppanel.Controls.Add(this.btntrans);
            this.Toppanel.Controls.Add(this.btnupdate);
            this.Toppanel.Controls.Add(this.btnadd);
            this.Toppanel.Controls.Add(this.btnstavailable);
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(1083, 86);
            this.Toppanel.TabIndex = 0;
            this.Toppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Toppanel_Paint);
            // 
            // btnoppanel
            // 
            this.btnoppanel.BackColor = System.Drawing.Color.Navy;
            this.btnoppanel.Location = new System.Drawing.Point(222, 31);
            this.btnoppanel.Name = "btnoppanel";
            this.btnoppanel.Size = new System.Drawing.Size(110, 4);
            this.btnoppanel.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(763, 31);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(111, 23);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "Exit Application";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // btnpaid
            // 
            this.btnpaid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpaid.Location = new System.Drawing.Point(655, 31);
            this.btnpaid.Name = "btnpaid";
            this.btnpaid.Size = new System.Drawing.Size(111, 23);
            this.btnpaid.TabIndex = 0;
            this.btnpaid.Text = "Paid Item";
            this.btnpaid.UseVisualStyleBackColor = true;
            this.btnpaid.Click += new System.EventHandler(this.Btnpaid_Click);
            // 
            // btntrans
            // 
            this.btntrans.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrans.Location = new System.Drawing.Point(546, 31);
            this.btntrans.Name = "btntrans";
            this.btntrans.Size = new System.Drawing.Size(111, 23);
            this.btntrans.TabIndex = 0;
            this.btntrans.Text = "Transaction";
            this.btntrans.UseVisualStyleBackColor = true;
            this.btntrans.Click += new System.EventHandler(this.Btntrans_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(439, 31);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(111, 23);
            this.btnupdate.TabIndex = 0;
            this.btnupdate.Text = "Update Item";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(329, 31);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(111, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add Item";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // btnstavailable
            // 
            this.btnstavailable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstavailable.Location = new System.Drawing.Point(221, 31);
            this.btnstavailable.Name = "btnstavailable";
            this.btnstavailable.Size = new System.Drawing.Size(111, 23);
            this.btnstavailable.TabIndex = 0;
            this.btnstavailable.Text = "Stock Availabale";
            this.btnstavailable.UseVisualStyleBackColor = true;
            this.btnstavailable.Click += new System.EventHandler(this.Btnstavailable_Click);
            // 
            // Centerpanel
            // 
            this.Centerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Centerpanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Centerpanel.Location = new System.Drawing.Point(0, 86);
            this.Centerpanel.Name = "Centerpanel";
            this.Centerpanel.Size = new System.Drawing.Size(1083, 460);
            this.Centerpanel.TabIndex = 1;
            this.Centerpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Centerpanel_Paint);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 546);
            this.Controls.Add(this.Centerpanel);
            this.Controls.Add(this.Toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainform";
            this.Text = "mainform";
            this.Toppanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnpaid;
        private System.Windows.Forms.Button btntrans;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnstavailable;
        private System.Windows.Forms.Panel Centerpanel;
        private System.Windows.Forms.Panel btnoppanel;
    }
}