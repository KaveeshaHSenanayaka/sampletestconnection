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
    public partial class registrationform : Form
    {
        public registrationform()
        {
            InitializeComponent();
        }
        string constr = "Data Source=localhost;Integrated Security=True;user=root;database=inventoryasbcompany;password=1234";
        private object username;
        


        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBxPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = checkBxPassword.Checked;
            txtconpw.UseSystemPasswordChar = checkBxPassword.Checked;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtconpw.Text = "";
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" && txtconpw.Text == "")
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO loginData (userName, userPassword) VALUES (@userName, @userPassword)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        string username = txtUser.Text.Trim();
                       
                        string password = txtPassword.Text.Trim();

                        cmd.Parameters.AddWithValue("@userName", username);
                        cmd.Parameters.AddWithValue("@userPassword", password);
                        
                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LblBacktologin_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
