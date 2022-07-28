using System.Text;

namespace CSDay4
{
    public class Program
    {
        // Định nghĩa 1 xe ô tô màu là RED, HSX là Toyota và model là Yaris 2022
        // Sau đó gọi phương thức PaintBlue để sơn xe thành màu BLUE
        // Sau đó lại gọi phương thức Paint để sơn xe thành màu ORANGE
        static void Test1()
        {
            // Định nghĩa xe
            Car mycar = new Car();

            // In các thuộc tính của xe
            mycar.PrintProps();


            mycar.Color = "RED";
            mycar.Maker = "Toyota";
            mycar.Model = "Yaris 2022";

            // In các thuôc tính của xe
            mycar.PrintProps();

            // Gọi phương thức
            Console.WriteLine("Sơn xe thành màu xanh");
            mycar.PaintBlue();

            // In các thuôc tính của xe
            mycar.PrintProps();

            // Gọi phương thức để sơn xe thành màu cam
            Console.WriteLine("Sơn xe thành màu cam");
            mycar.Paint("ORANGE");
            // In các thuôc tính của xe
            mycar.PrintProps();
        }

        // Gọi hàm khởi tạo
        static void Test2()
        {
            // Gọi hàm khởi tạo mycar với tham số
            // mycar là đối tương, là thể hiện (instance) của lớp (class) Car
            Car mycar = new Car("Xanh", "Landrover", "Rangerover 2022");

            // in các tham số của mycar
            mycar.PrintProps();

            mycar.CheckVariable("Tím");

            mycar.HamCongKhai();

            Console.WriteLine(mycar.LayThuocTinhAn());
        }

        // Định nghĩa một cái xe máy
        // Minh hoạ hành vi của một cái xe máy
        // di chuyển theo 4 hướng đông / tây / nam / bắc
        // các hành động gồm: tiến về phía trước và quay phải / quay trái
        static void Test3()
        {
            Bike bike = new Bike();
            bike.PrintPosition();
            bike.Foward(); // tiến về phía trước 1 ô 
            bike.Foward(); // tiến về phía trước 1 ô
            bike.PrintPosition();
            bike.RotateLeft(); // quay trái: hướng bắc => tây
            bike.Foward(); // tiến về hướng tây 1 bước
            bike.PrintPosition();
            bike.RotateRight(); // Quay phải tây => bắc
            bike.PrintPosition();
            bike.Foward();
            bike.Foward();
            bike.PrintPosition();
            bike.RotateRight(); // Quay phải bắc => đông
            bike.Foward();
            bike.Foward();
            bike.Foward();
            bike.Foward(); // tiến về hướng đông 4 bước
            bike.PrintPosition();
            bike.RotateRight(); // Quay phải đông => nam
            bike.Foward(); // tiến về hướng đông 4 bước
            bike.Foward(); // tiến về hướng đông 4 bước
            bike.Foward(); // tiến về hướng đông 4 bước
            bike.PrintPosition();
        }

        // Test biến và hàm static
        static void Test4()
        {
            Console.WriteLine($"Thời tiết là {Bike.ThoiTiet}");
            Bike bike = new Bike();
            bike.ThayDoiThoiTiet();
            Console.WriteLine($"Thời tiết là {Bike.ThoiTiet}");
            Bike.ThayDoiTTStatic();
            Console.WriteLine($"Thời tiết là {Bike.ThoiTiet}");
        }

        // lưu cấu hình trình duyệt vào static
        static void Test5()
        {
            Chrome chrome = new Chrome();
            Firefox firefox = new Firefox();
            Console.WriteLine($"firefox={firefox.Url}, chrome={chrome.Url}, config={Config.LastVisit}");
            chrome.Open("https://chat.zalo.me/");
            Console.WriteLine($"firefox={firefox.Url}, chrome={chrome.Url}, config={Config.LastVisit}");
            firefox.Open("https://github.com/lamnguyen917/GU0722E");
            Console.WriteLine($"firefox={firefox.Url}, chrome={chrome.Url}, config={Config.LastVisit}");
            firefox.Open("https://google.com");
            Console.WriteLine($"firefox={firefox.Url}, chrome={chrome.Url}, config={Config.LastVisit}");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Test1();
            // Test2();
            // Test3();

            // Test4();
            Test5();
        }
    }
}