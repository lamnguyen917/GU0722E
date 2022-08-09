using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaiTapDay5.Bai1;
using BaiTapDay5.Bai2;
using BaiTapDay5.Bai3;

namespace Day5BT

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài 1 =============================================================");
            execute_bai1();
            Console.WriteLine("\nBài 2 =============================================================");

            execute_bai2();
            Console.WriteLine("\nBài 3 =============================================================");
            execute_bai3();
        }

        static void execute_bai3()
        {
            //Tạo 5 student và 1 teacher, cho các student giới thiệu và teacher sẽ bắt đầu buổi học.
            RunBai3 execute = new RunBai3();

            Console.WriteLine("Tạo 5 student và 1 teacher, cho các student giới thiệu và teacher sẽ bắt đầu buổi học");
            execute.set_students_age();
            execute.let_students_introduce();
        }


        static void execute_bai2()
        {
            ITStudent student_duy = new ITStudent("Duy", "10D4", "Nam", 9);
            student_duy.SetScore(new[] { 8f, 7f, 9f, 6f, 4f, 3f, 9f });
            ITStudent student_manh = new ITStudent("Mạnh", "10A3", "Nam", 7);
            student_manh.SetScore(new[] { 4f, 5f, 2f, 3f, 4f, 3f, 5f });
        }


        static void execute_bai1()
        {
            RunBai1 execute = new RunBai1();


            // In thông tin 5 sinh viên
            Console.WriteLine("In thông tin 5 sinh viên");

            execute._print_5_students_info();

            //sửa đổi thông tin các tham số sinh viên
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Sửa đổi thông tin các tham số sinh viên");

            execute._change_student_info();


            //tham số truyền vào là một collection, set điểm (score) của object là trung bình cộng của collection, 
            //... in ra thông báo cảnh cáo nếu điểm trung bình cộng đó nhỏ hơn 6.
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(
                "trung bình cộng của collection, in ra thông báo cảnh cáo nếu điểm trung bình cộng đó nhỏ hơn 6");
            execute.set_exist_student_multi_scores("Anh", new[] { 7f, 6f, 7f, 9f, 5f, 3f });
            execute.set_exist_student_multi_scores("Cường", new[] { 4f, 5f, 3f, 4f, 5f, 3f });
            execute.set_exist_student_multi_scores("Duy", new[] { 4f, 5f, 3f, 4f, 5f, 3f });

            //Tạo danh sách điểm toán cao cấp, triết học cho các sinh viên trên, in ra thông tin điểm từng sinh viên.
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(
                "Tạo danh sách điểm toán cao cấp, triết học cho các sinh viên trên, in ra thông tin điểm từng sinh viên");
            execute._create_subjects_scores_for_students();
        }
    }
}
