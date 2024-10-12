using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATABASE
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        public class Database
        {
            private string connectionString = "Data Source=SERVER;Initial Catalog=YourDatabase;Integrated Security=True";

            public DataTable ExecuteQuery(string query)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        private void btthongkesp_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, SUM(ImportQuantity) AS TotalImportQuantity FROM Products GROUP BY ProductID, ProductName";
            Database db = new Database();
            DataTable dt = db.ExecuteQuery(query);
            dataGridView1.DataSource = dt;
        }

        private void btthongkedoanhthu_Click(object sender, EventArgs e)
        {
            string query = "SELECT SaleDate, SUM(SaleAmount) AS TotalSales FROM Sales GROUP BY SaleDate";
            Database db = new Database();
            DataTable dt = db.ExecuteQuery(query);
            dataGridView2.DataSource = dt;
        }

        private void btthongkeloinhuan_Click(object sender, EventArgs e)
        {
            string query = "SELECT p.ProductName, e.EmployeeName, SUM(s.Profit) AS TotalProfit " +
                   "FROM Sales s " +
                   "JOIN Products p ON s.ProductID = p.ProductID " +
                   "JOIN Employees e ON s.EmployeeID = e.EmployeeID " +
                   "GROUP BY p.ProductName, e.EmployeeName";
            Database db = new Database();
            DataTable dt = db.ExecuteQuery(query);
            dataGridView3.DataSource = dt;
        }

    }
}
