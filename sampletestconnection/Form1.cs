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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

            // Set initial state of password textbox
            txtPassword.UseSystemPasswordChar = true;
        }
        string constr = "server=localhost;user=root;database=inventoryasbcompany;password=1234";
        private void Button1_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM loginData WHERE userName = @username AND userPassword = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    if (result > 0)
                    {
                        mainform mainform = new mainform();
                        mainform.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }



        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnRegister.PerformClick(); // This triggers the actual login button
            }

        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void CheckBxPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBxPassword.Checked;
        }
            private void Lblca_Click(object sender, EventArgs e)
        {
            registrationform registrationform = new registrationform();
            registrationform.Show();
            this.Hide();

        }
        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    internal class MainPage
    {
    }
}

