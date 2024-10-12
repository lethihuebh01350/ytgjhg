using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATABASE
{
    internal static class Program
    {
        /// <summary>
        /// Điểm khởi đầu của ứng dụng.
        /// </summary>
        [STAThread] // Thuộc tính này cho biết rằng ứng dụng sử dụng mô hình COM STA
        static void Main()
        {
            Application.EnableVisualStyles(); // Kích hoạt kiểu giao diện người dùng hiện đại
            Application.SetCompatibleTextRenderingDefault(false); // Đặt chế độ render văn bản
            Application.Run(new Form5()); // Khởi động Form1
        }

    }
}
