﻿using System.Text;

namespace CSDay3
{
    // Đề bài : Viết chương trình kiểm tra tính hợp lệ của mật khẩu mật khẩu hợp lệ chứa ít nhất 6 ký tự có
    // cả chữ và số ( ko có các ký tự @,#,*,... và khoảng trắng) . Cho ng dùng nhập vào mật khẩu để so sánh
    // nếu đúng đăng nhập thành công nếu sai quá 5 lần thoát khỏi chương trình. 

    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập mk muốn tạo vào đây ( lưu ý phải trên 6 ký tự , phải vừa có cả số và chữ ) : ");
            string mk = Console.ReadLine();
            bool check = true;
            while (check)
            {
                int dem_so = 0, dem_chu = 0, dem_space = 0, dem_kytu = 0;
                foreach (char i in mk)
                {
                    if (char.IsDigit(i))
                    {
                        dem_so++;
                    }
                    else if (char.IsLetter(i))
                    {
                        dem_chu++;
                    }
                    else if (char.IsWhiteSpace(i))
                    {
                        dem_space++;
                    }
                    else
                    {
                        // !@#$%^^^
                        dem_kytu++;
                    }
                }

                Console.WriteLine(
                    $"dem_so: {dem_so}, den_chu: {dem_chu}, do dai: {mk.Length}, dem_space: {dem_space}, dem_kytu: {dem_kytu}");
                if (dem_so * dem_chu != 0 && mk.Length >= 6 && dem_space == 0 && dem_kytu == 0)
                {
                    Console.WriteLine("Dang nhap thanh cong");
                    check = false;
                }
                else
                {
                    Console.Write("nhập lại mk (ít nhất phải có 6 ký tự và không có ký tự @,#,$,...): ");
                    mk = Console.ReadLine();
                }
            }

            Console.ReadKey();
        }
    }
}