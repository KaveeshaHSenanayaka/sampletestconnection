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
    public partial class addItemForm : Form
    {
        public addItemForm()
        {
            InitializeComponent();
            AddItemStock();
            LoadStockData();

            dgvAddItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        string constr = "Data Source=localhost;Integrated Security=True;user=root;database=inventoryasbcompany;password=1234";

        public void LoadStockData(string searchquery = "")
        {
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Item_ID,Item_Name,Initial_Quantity FROM item";

                    if (!string.IsNullOrEmpty(searchquery))
                    {
                        query = $"SELECT Item_ID,Item_Name,Initial_Quantity FROM item WHERE Item_Name like'%{searchquery}%'";
                    }
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvAddItem.DataSource = null;
                    dgvAddItem.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        public void AddItemStock()
        {
            using  (MySqlConnection conn = new MySqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM item";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvAddItem.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }
        private void Btnadditem_Click(object sender, EventArgs e)
        {
            // Read data from textboxes
            string itemName = txtItemName.Text.Trim();
            int Quantity;

            // Validate if the quantity is a number
            if (!int.TryParse(txtQuantity.Text.Trim(), out Quantity))
            {
                MessageBox.Show("Please enter a valid number for Quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert data into MySQL database
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Item (Item_Name, Initial_Quantity) VALUES (@name, @quantity)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Use parameters to prevent SQL Injection
                    cmd.Parameters.AddWithValue("@name", itemName);
                    cmd.Parameters.AddWithValue("@quantity", Quantity);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear textboxes after adding data
                    txtItemName.Clear();
                    txtQuantity.Clear();

                    // Refresh data grid (if applicable)
                    LoadStockData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                try
                {
                    string itemName = txtItemName.Text, itemid = txtItemID.Text, Quantity = txtQuantity.Text;
                    
                    conn.Open();
                    string query = "Delete FROM Item WHERE Item_ID = '" + itemid + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear textboxes after deleting data
                    txtItemID.Clear();
                    txtItemName.Clear();
                    txtQuantity.Clear();

                    // Refresh data grid (if applicable)
                    LoadStockData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {

        }

        private void addItemForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvAddItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
