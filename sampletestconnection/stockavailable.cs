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
    public partial class stockavailable : Form
    {


        public stockavailable()
        {
            InitializeComponent();
            LoadStockData();
        }

        string constr = "Data Source=localhost;Integrated Security=True;user=root;database=inventoryasbcompany;password=1234";

        public void LoadStockData(string searchquery ="")
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
                    dgvStockavailable.DataSource = dt;

                    dgvStockavailable.DefaultCellStyle.Font = new Font("Times New Roman",13);
                    dgvStockavailable.ColumnHeadersDefaultCellStyle.Font = new Font("Times New RomanI", 12, FontStyle.Bold);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
      
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
                using (MySqlConnection con = new MySqlConnection(constr))
            {
                try
                {
                    con.Open();
                    string searchquery = "Select * FROM item WHERE Item_Name LIKE @ItemName";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(searchquery, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@ItemName", "%" +txtsearch.Text + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvStockavailable.DataSource = dt;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvStockavailable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stockavailable_Load(object sender, EventArgs e)
        {

        }
    }
}
