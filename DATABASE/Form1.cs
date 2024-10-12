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
    public partial class Form1 : Form
    {
        private object lblMessage;

        public Form1()
        {
            InitializeComponent();

             // Đăng ký sự kiện MouseEnter và MouseLeave cho nút btnLogin
            btlogin.MouseEnter += BtnLogin_MouseEnter;
            btlogin.MouseLeave += BtnLogin_MouseLeave;
        }
        // Khi di chuột vào nút btnLogin
        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            btlogin.BackColor = Color.Pink; // Đổi màu nền thành màu hồng
        }

        // Khi di chuột ra khỏi nút btnLogin
        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            btlogin.BackColor = SystemColors.Control; // Đặt lại màu nền mặc định
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            // Xử lý đăng nhập
            string username = tbname.Text.Trim();
            string password = tbpass.Text.Trim();

            if (username == "lethihue" && password == "12345")
            {
                // Đăng nhập thành công, mở Form2
                Form2 mainForm = new Form2();
                mainForm.Show();
                this.Hide(); // Ẩn Form1 (Form đăng nhập)
            }
            else
            {
                // Hiển thị thông báo lỗi nếu tên đăng nhập hoặc mật khẩu sai
                lbname.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
                lbname.ForeColor = Color.Red;
            }
        }
    }
}
