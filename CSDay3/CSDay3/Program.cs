using System.Text;

namespace CSDay3
{
    // Đề bài : Viết chương trình kiểm tra tính hợp lệ của mật khẩu mật khẩu hợp lệ chứa ít nhất 6 ký tự có
    // cả chữ và số ( ko có các ký tự @,#,*,... và khoảng trắng) . Cho ng dùng nhập vào mật khẩu để so sánh
    // nếu đúng đăng nhập thành công nếu sai quá 5 lần thoát khỏi chương trình. 

    public class Program
    {
        int Tong(int x, int y)
        {
            return x + y;
        }

        static string Tong2So(int x, int y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            return $"Tong 2 so {x} va {y} la {x + y}";
        }

        static void Main(string[] args)
        {
            // string s = Tong2So(10, 20);
            // Console.WriteLine(s);
            Program program = new Program();
            Console.WriteLine(program.Tong(4, 6));
        }
    }
}