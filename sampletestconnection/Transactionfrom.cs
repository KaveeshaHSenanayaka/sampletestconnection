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
    public partial class Transactionfrom : Form
    {
        public Transactionfrom()
        {
            InitializeComponent();
            LoadStockData();
        }
        string constring = "Data Source=localhost;Integrated Security=True;user=root;database=inventoryasbcompany;password=1234";

        private void BtnTransaction_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                try
                {
                    conn.Open();

                    int itemID = int.Parse(txtItemID.Text);
                    int quantity = int.Parse(txtQuantity.Text);
                    string transactionType = ComboTransaction.SelectedItem.ToString();

                    if (quantity <= 0)
                    {
                        MessageBox.Show("Quantity must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 1. Get current quantity
                    int currentQuantity = 0;
                    using (MySqlCommand cmd = new MySqlCommand("SELECT Initial_Quantity FROM item WHERE Item_ID = @itemID", conn))
                    {
                        cmd.Parameters.AddWithValue("@itemID", itemID);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            currentQuantity = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Item not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // 2. Update item quantity
                    int newQuantity = transactionType == "Remove" ? currentQuantity - quantity : currentQuantity + quantity;

                    if (transactionType == "Remove" && quantity > currentQuantity)
                    {
                        MessageBox.Show("Not enough stock available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (MySqlCommand cmd = new MySqlCommand("UPDATE item SET Initial_Quantity = @newQuantity WHERE Item_ID = @itemID", conn))
                    {
                        cmd.Parameters.AddWithValue("@newQuantity", newQuantity);
                        cmd.Parameters.AddWithValue("@itemID", itemID);
                        cmd.ExecuteNonQuery();
                    }

                    // 3. Insert project if not exists
                    int projectID = 0;
                    using (MySqlCommand cmd = new MySqlCommand("SELECT Project_ID FROM Project WHERE Project_Name = @projectName", conn))
                    {
                        cmd.Parameters.AddWithValue("@projectName", txtProjectName.Text.Trim());
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            projectID = Convert.ToInt32(result);
                        }
                        else
                        {
                            using (MySqlCommand insertCmd = new MySqlCommand("INSERT INTO Project (Project_Name, Project_Timestamp) VALUES (@projectName, @timestamp)", conn))
                            {
                                insertCmd.Parameters.AddWithValue("@projectName", txtProjectName.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@timestamp", DateTime.Now);
                                insertCmd.ExecuteNonQuery();
                                projectID = (int)insertCmd.LastInsertedId;
                            }
                        }
                    }

                    // 4. Insert transaction record (Note the backticks around `Transaction`)
                    using (MySqlCommand cmd = new MySqlCommand(@"
                INSERT INTO `Transactions` (Employee_ID, Item_ID, Project_ID, Transaction_Type, Quantity) 
                VALUES (@employeeID, @itemID, @projectID, @transactionType, @quantity)", conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeID", 1); // Static for now
                        cmd.Parameters.AddWithValue("@itemID", itemID);
                        cmd.Parameters.AddWithValue("@projectID", projectID);
                        cmd.Parameters.AddWithValue("@transactionType", transactionType);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Transaction recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LoadStockData(string searchQuery = "")
        {
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Item_ID, Item_Name,Initial_Quantity FROM Item"; // Fetch only necessary columns

                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        query = $"SELECT Item_ID, Item_Name,Initial_Quantity FROM Item WHERE Item_Name LIKE '%{searchQuery}%'";
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTransaction.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTransaction.Rows[e.RowIndex];
                txtItemID.Text = row.Cells["Item_ID"].Value.ToString(); // Store Item_ID
                txtItemName.Text = row.Cells["Item_Name"].Value.ToString(); // Populate Item Name
                txtQuantity.Text = row.Cells["Initial_Quantity"].Value.ToString(); // Populate Item Quantity
            }
        }

        private void TxtSearchitem_TextChanged(object sender, EventArgs e)
        {
            LoadStockData(txtSearchitem.Text.Trim());
        }
        private void UpdateItemForm_Load(object sender, EventArgs e)
        {
            dgvTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransaction.MultiSelect = false;
            dgvTransaction.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTransaction.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;



        }
        private void Transactionfrom_Load(object sender, EventArgs e)
        {
            ComboTransaction.Items.Add("Remove");
            ComboTransaction.Items.Add("Return");
            ComboTransaction.SelectedIndex = 0; // Default selection
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void ComboTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProjectName_Click(object sender, EventArgs e)
        {

        }

        private void lblSize_Click(object sender, EventArgs e)
        {

        }

        private void lblItemName_Click(object sender, EventArgs e)
        {

        }

        private void lblQty_Click(object sender, EventArgs e)
        {

        }
    }
}
