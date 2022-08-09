using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDay6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Print("Bài 1");
            execute_bai1();

            Print("\nBài 2");
            execute_bai2();

        }


        
        static void execute_bai1()
        {
            BaiTap1 execute = new BaiTap1();
            Print("Tính tổng các số từ 1 -> 1000000 (1 triệu) bằng 1 thread. Đếm giây cho thời gian tính.");
            execute.using_1_threading();
            Print("======================================================================================");
            Print("Tính tổng các số từ 1 -> 1000000 (1 triệu) bằng 4 thread. Đếm giây cho thời gian tính");
            execute.using_4_threadings();

        }

        static void execute_bai2()
        {
            BaiTap2 exe = new BaiTap2();
            exe.input_students_data_to_file("test_write.txt");
            BaiTap2.read_data_file("test_write.txt");
        }





        public static void Print(string text)
        {
            Console.WriteLine(text);
        }

    }
}
