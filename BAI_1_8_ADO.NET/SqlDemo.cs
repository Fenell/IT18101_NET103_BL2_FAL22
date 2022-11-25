using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_8_ADO.NET
{
    internal class SqlDemo
    {
        //Khai báo Connection String
        private readonly string _conString = @"Data Source=DESKTOP-CFK23F4\SQLEXPRESS;Initial Catalog=qlbh;Integrated Security=True";

        // VD1: test kết nối
        public void tryConnect()
        {
            try
            {
                //Khai báo đối tượng SqlConnection để kết nối tới database
                //Tham số truyền vào SqlConnect khi khởi tạo là chuỗi Connection string
                SqlConnection conn = new SqlConnection(_conString);

                //Mở kết nối database
                conn.Open();

                //THực hiện .... database
                Console.WriteLine("Connect Ok!");
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Can't connect to database");
            }
        }

        public void insert()
        {
            //Khối thể Using: Sử dụng với các class implement interface
            // IDispoale
            //Tác dụng : tự động connection, ngắt kết nối với tệp tin... thay vì phải gọi phương thức đóng thủ công
            try
            {
                var query = "INSERT INTO Shippers (Hoten, Sodienthoai) VALUES (N'Bee', N'0392132059')";
                using (var conn = new SqlConnection(_conString))
                {
                    conn.Open();
                    //đối tượng SQLCommand: tương tác các lệnh với database
                    // Truyền vào SqlCommand(chuỗi query, đối tượng Connection)
                    SqlCommand cmd = new SqlCommand(query, conn);

                    //THực hiện truy vấn không trả về dữ liệu
                    //Tương tự với truy vấn update, delete
                    // ExecuteNonQuery() thực hiện câu lệnh truy vấn và trả về số bản ghi trong database mà nó tác động lên
                    if (cmd.ExecuteNonQuery() >0)
                    {
                        Console.WriteLine("Thực hiện thành công");
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Thực hiện không thành công");
            }
        }

        public void select()
        {
            try
            {
                var query = "Select * from Sanpham";
                using (var conn = new SqlConnection(_conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // Sql Cammand.ExecuteReader() trả về đối tượng SqlDataReader
                    SqlDataReader reader = cmd.ExecuteReader();

                    //ĐỌc dữ liệu với SqlDataReader
                    while (reader.Read())
                    {
                        // Lấy getString hay get(Kiểu dữ liệu) phụ thuộc vào kiểu dữ liệu của trường đó trong database
                        Console.WriteLine($"{reader.GetString(0)} {reader.GetDecimal(1)}");
                        //Cach 2 truyền vào cột cần láy (tên tương ứng với trong query)

                        
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Có lỗi trong quá trình thực thi");
            }
        }
    }
}
