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
    public partial class Paiditemform : Form
    {
        public Paiditemform()
        {
            InitializeComponent();
            LoadStockData();
        }
        string constr = "Data Source=localhost;Integrated Security=True;user=root;database=inventoryasbcompany;password=1234";

        public void LoadStockData(string searchquery = "")
        {
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Item_ID,Item_Name,hire_for_hours,price FROM paid_item";

                    if (!string.IsNullOrEmpty(searchquery))
                    {
                        query = $"SELECT Item_ID,Item_Name,hire_for_hours,price FROM paid_item WHERE Item_Name like'%{searchquery}%'";
                    }
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPaidItem.DataSource = null;
                    dgvPaidItem.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void BtnPaidItem_Click(object sender, EventArgs e)
        {
            string id = txtItemID.Text.Trim(), itemname = txtItemName.Text, hire = txtHireforHours.Text, price = txtprice.Text;
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO paid_item (item_ID, Item_Name ,hire_for_hours ,price) Values(@id,@name,@Hours, @price)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Use parameters to prevent SQL Injection
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", itemname);
                    cmd.Parameters.AddWithValue("@Hours", hire);
                    cmd.Parameters.AddWithValue("@price", price);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear textboxes after adding data
                    txtItemID.Clear();
                    txtItemName.Clear();
                    txtHireforHours.Clear();
                    txtprice.Clear();

                    // Refresh data grid (if applicable)
                    LoadStockData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Paiditemform_Load(object sender, EventArgs e)
        {

        }
    }
    }

