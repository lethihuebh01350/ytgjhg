using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATABASE
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }
        private void dgvgridview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btadd_Click(object sender, EventArgs e)
        {
            

        }

       
        
        private void textboxsearch_Enter(object sender, EventArgs e)
        {
        }

        

        private void LoadData()
        {
           
        }

        private void btclear_Click(object sender, EventArgs e)
        {
           
        }

        private void btFromFire_Click(object sender, EventArgs e)
        {
           
        }
               
        
        
        private void Form5_Load_1(object sender, EventArgs e)
        {
            // Initialize the ImageList if you're using one, or load images directly
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(50, 50); // Set the size for images

            // Load images from the file system (use the correct paths)
            imageList.Images.Add(Image.FromFile(@"C:\Users\Hp\Downloads\images.jpg"));
            imageList.Images.Add(Image.FromFile(@"C:\Users\Hp\Downloads\ao-dong-phuc-mau-hong.jpg"));

            // Ensure the DataGridView is clear before adding new data
            //dgvgridview.Rows.Clear();

            // Add the first product
            Image productImage1 = imageList.Images[0]; // Image from the ImageList
            //dgvgridview.Rows.Add(productImage1, "Product A", "Category 1", "5000");

            // Add the second product
            Image productImage2 = imageList.Images[1]; // Image from the ImageList
            //dgvgridview.Rows.Add(productImage2, "Product B", "Category 2", "7000");
        }

        
    }
}
