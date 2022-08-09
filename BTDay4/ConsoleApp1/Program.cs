using System;
using System.Text;

// Định nghĩa 1 class Robot
// * Thuộc tính
//     - Vị trí X và Y
//     - Màu sắc
//     - Tên
//     * Hành Động
//     - Tiến: tăng Y them 1
//     - Lùi: giảm Y  đi 1 đơn vị
//     - Sang phải: tăng X thêm 1 
//     - Sang trái: giảm X đi 1
//
// Tạo 2 robot là Jarvis và Droid:
// - Jarvis có màu đỏ, đứng ở vị trí x=10,y=10
// - Droid có màu xanh, đứng ở vị trí x=0,y=0
//
// 2 Robot lần lượt thực hiện những hành động sau
//     - Jarvis sang trái 5 lần
//     - Droid tiến 4 lần
//     - Jarvis lùi 3 lần
//     - Droid tiến 3 lần
//     - Droid sáng trái 4 lần
//
//     Sau mỗi lần 1 robot thực hiện hành động, in ra console vị trí của 2 robot và kiểm tra xem chúng có gặp nhau không

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ;
            Robot jarvis = new Robot();

            jarvis.color = "Red";
            jarvis.name = "Jarvis";
            jarvis.set_starting_pos(10, 10);

            Robot droid = new Robot();
            droid.color = "Blue";
            droid.name = "Droid";
            droid.set_starting_pos(0, 0);

            Console.WriteLine($"Robot 1 name : " + jarvis.name);
            Console.WriteLine($"Robot 1 color  : " + jarvis.color);
            jarvis.print_robot_cur_position();
            Console.WriteLine($"Robot 2 name : " + droid.name);
            Console.WriteLine($"Robot 2 color : " + droid.color);
            droid.print_robot_cur_position();

            Console.WriteLine($"----------------------------------------------------------------------------");

            Console.WriteLine("Jarvis sang trái 5 lần");
            jarvis.MoveLeftMultipleTimes(5);
            jarvis.print_robot_cur_position();
            Robot.CheckCollision(jarvis, droid);


            Console.WriteLine($"----------------------------------------------------------------------------");

            Console.WriteLine("Droid tiến 4 lần");
            droid.ForwardMultipleTimes(4);
            droid.print_robot_cur_position();
            Robot.CheckCollision(jarvis, droid);

            Console.WriteLine($"----------------------------------------------------------------------------");
            Console.WriteLine("Jarvis lùi 3 lần");
            jarvis.FallbackMultipleTimes(3);
            jarvis.print_robot_cur_position();
            Robot.CheckCollision(jarvis, droid);

            Console.WriteLine($"----------------------------------------------------------------------------");
            Console.WriteLine(" Droid tiến 3 lần");
            droid.ForwardMultipleTimes(3);
            droid.print_robot_cur_position();
            Robot.CheckCollision(jarvis, droid);

            Console.WriteLine($"----------------------------------------------------------------------------");
            Console.WriteLine("Droid sang trái 4 lần");
            droid.MoveLeftMultipleTimes(4);
            droid.print_robot_cur_position();
            Robot.CheckCollision(jarvis, droid);

            // Mở rộng bài toán: Di chuyển lần lượt Jarvis và Droid để 2 robot gặp nhau
            Console.WriteLine($"----------------------------------------------------------------------------");
            // hiện tại Jarvis ở vị trí (5,7) và Droid ở vị trí (-4,7), chúng ta di chuyển droid sang phải
            // 9 lần 
            droid.MoveRightMultipleTimes(9);
            droid.print_robot_cur_position();
            Robot.CheckCollision(jarvis, droid);
        }
    }
}
