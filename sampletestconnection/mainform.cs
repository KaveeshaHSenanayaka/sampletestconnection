using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace sampletestconnection
{
    public partial class mainform : Form
    {
        //private MainForm _mainForm;

        public mainform()
        {
            InitializeComponent();
        }

        private void LoadForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Centerpanel.Controls.Clear();
            Centerpanel.Controls.Add(form);
            form.Show();
           
        }

        private void MovePanel(Control btn)
        {
            btnoppanel.Left = btn.Left;
            btnoppanel.Width = btn.Width;
        }

        public void LoadContentIntoPanel(Control content)
        {
            Centerpanel.Controls.Clear();
            content.Dock = DockStyle.Fill;
            Centerpanel.Controls.Add(content);
        }


        private void Btnstavailable_Click(object sender, EventArgs e)
        {
            MovePanel(btnstavailable);
            LoadForm(new stockavailable());
            //stockavailable Stockavailable = new stockavailable();
            //Stockavailable.ShowDialog();

            
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            MovePanel(btnadd);
            LoadForm(new addItemForm());           
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            MovePanel(btnupdate);
            LoadForm(new UpdateItemForm());
        }


       

        private void Btntrans_Click(object sender, EventArgs e)
        {
            MovePanel(btntrans);
            LoadForm(new Transactionfrom());
           
        }

        private void Btnpaid_Click(object sender, EventArgs e)
        {
            MovePanel(btnpaid);
            LoadForm(new Paiditemform());
           
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Toppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Centerpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
