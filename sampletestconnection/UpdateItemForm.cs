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
    public partial class UpdateItemForm : Form
    {
        public UpdateItemForm()
        {
            InitializeComponent();
            LoadStockData();
        }
        string connectionString = "Data Source=localhost;Integrated Security=True;user=root;database=inventoryasbcompany;password=1234";

        public void LoadStockData(string searchQuery = "")
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Item_ID, Item_Name, Initial_Quantity FROM Item"; // Fetch only necessary columns

                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        query = $"SELECT Item_ID, Item_Name, Item_Size FROM Item WHERE Item_Name LIKE '%{searchQuery}%'";
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUpdateItem.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtItemID.Text))
            {
                MessageBox.Show("Please select an item and fill in all fields before updating.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Item SET Item_Name = @name, Initial_Quantity = @quantity WHERE Item_ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtItemName.Text.Trim());
                        cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", txtItemID.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStockData(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please check the item selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UpdateItemForm_Load(object sender, EventArgs e)
        {
            dgvUpdateItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUpdateItem.MultiSelect = false;
            dgvUpdateItem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUpdateItem.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvUpdateItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUpdateItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void DgvUpdateItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUpdateItem.Rows[e.RowIndex];
                txtItemID.Text = row.Cells["Item_ID"].Value.ToString(); // Store Item_ID
                txtItemName.Text = row.Cells["Item_Name"].Value.ToString(); // Populate Item Name
                txtQuantity.Text = row.Cells["Initial_Quantity"].Value.ToString(); // Populate Item Quantity
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
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
    }
}
