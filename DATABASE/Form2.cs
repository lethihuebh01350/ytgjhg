using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATABASE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mở Form3 khi nhấn vào nút Customers
            Form3 customersForm = new Form3();
            customersForm.Show(); // Hoặc sử dụng ShowDialog() nếu bạn muốn mở dưới dạng hộp thoại
        }

        private void lbhome_Click(object sender, EventArgs e)
        {

        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            // Mở Form4 khi nhấn vào nút Employee
            Form4 employeeForm = new Form4();
            employeeForm.Show();
        }

        private void btproduct_Click(object sender, EventArgs e)
        {
            // Mở Form5 khi nhấn vào nút Product
            Form5 productForm = new Form5();
            productForm.Show();
        }

        private void btstatistics_Click(object sender, EventArgs e)
        {
            // Mở Form6 khi nhấn vào nút Statistics
            Form6 statisticsForm = new Form6();
            statisticsForm.Show();
        }

        private void btout_Click(object sender, EventArgs e)
        {
            // Create an instance of Form1
            Form1 form1 = new Form1();

            // Show Form1
            form1.Show();

            // Close Form2
            this.Close();
        }

    }
}
