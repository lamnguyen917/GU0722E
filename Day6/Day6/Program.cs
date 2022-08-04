using System.Text;

namespace Day6;

class Program
{
    static int X = -1;

    static void Write(string content)
    {
        Console.WriteLine(content + "============>" + X);
    }

    static readonly object Identity = new object();

    static void F1()
    {
        lock (Identity)
        {
            Thread thread = new Thread(F2);
            thread.Start();
            thread.Join();
            // F2 ở đây được joint với F1, tức là là chạy cùng với luồng chạy của F1, tương đương với việc
            // F2 được nối vào đầu F1 nếu chạy trong thread
            // Nếu F1 không chạy trong thread nào, thì F1 vẫn chạy bất đồng bộ với F1
            X = 1;
            Write("Đây là dòng lệnh F1 1");
            X = 2;
            Write("Đây là dòng lệnh F1 2");
            X = 3;
            Write("Đây là dòng lệnh F1 3");
            X = 4;
            Write("Đây là dòng lệnh F1 4");
            X = 5;
            Write("Đây là dòng lệnh F1 5");
            X = 6;
            Write("Đây là dòng lệnh F1 6");
            // Hàm sleep chờ 5s (tức là 5000ms) thì mới xử lý tiếp
            Thread.Sleep(5000);
            X = 7;
            Write("Kết thúc hàm F1");
        }
    }

    static void F2()
    {
        X = 8;
        Write("Đây là dòng lệnh F2 1 #############");
        X = 9;
        Write("Đây là dòng lệnh F2 2 #############");
        X = 10;
        Write("Đây là dòng lệnh F2 3 #############");
        X = 11;
        Write("Đây là dòng lệnh F2 4 #############");
        X = 12;
        Write("Đây là dòng lệnh F2 5 #############");
        X = 13;
        Write("Đây là dòng lệnh F2 6 #############");
        Thread.Sleep(1000);
        X = 14;
        Write("Kết thúc hàm F2");
    }

    static void F3()
    {
        X = 15;
        Write(" #############Đây là dòng lệnh F3 1 #############");
        X = 16;
        Write(" #############Đây là dòng lệnh F3 2 #############");
        X = 17;
        Write(" #############Đây là dòng lệnh F3 3 #############");
        X = 18;
        Write(" #############Đây là dòng lệnh F3 4 #############");
        X = 19;
        Write(" #############Đây là dòng lệnh F3 5 #############");
        X = 20;
        Write(" #############Đây là dòng lệnh F3 6 #############");
        X = 21;
        Write("Kết thúc hàm F3");
    }

    // F1 chạy hết hơn 10s, F2 phải chờ hơn 10s để F1 chạy thì mới xử lý
    static void Test1()
    {
        // Nếu F1 chạy quá lâu
        F1();
        // F2 phải chờ F1 chạy xong thì mới xử lý
        F2();
    }

    static void Test2()
    {
        Thread thread = new Thread(F1);
        thread.Name = "THREAD1";
        thread.Start();
        F2();
        F3();
    }

    // Đọc ghi file dùng các hàm static trong class File
    static void Test3()
    {
        const string contentToWrite =
            "In this article, there are several examples showing various ways to write text to a file. The first two examples use static convenience methods on the System.IO.File class to write each element of any IEnumerable<string> and a string to a text file. The third example shows how to add text to a file when you have to process each line individually as you write to the file. In the first three examples, you overwrite all existing content in the file. The final example shows how to append text to an existing file";
        var exists = File.Exists("test_write.txt");
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>  File có tồn tại === " + exists);

        Console.WriteLine("Gọi hàm xoá file");
        File.Delete("test_write.txt");
        exists = File.Exists("test_write.txt");
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>  File có tồn tại === " + exists);

        // Ghi nội dung vào file test_write.txt, file này sẽ được lưu ở thư mục chạy chứa file exe của chương trình
        // tìm thư mục chạy trong thư mục bin, tuỳ theo cấu hình chạy của project
        Console.WriteLine("Ghi file mới");
        File.WriteAllText("test_write.txt", contentToWrite);
        File.WriteAllText("D:\\demo.txt", contentToWrite);

        exists = File.Exists("test_write.txt");
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>  File có tồn tại === " + exists);

        var content = File.ReadAllLines("test_write.txt");
        for (int i = 0; i < content.Length; i++)
        {
            Console.WriteLine(content[i]);
        }

        try
        {
            File.Move("test_write.txt", "../new_test_write.txt");
        }
        catch (IOException ioException)
        {
        }
    }

    // Ghi file dùng stream
    static void Test4()
    {
        StreamWriter writer = new StreamWriter("stream_file.txt");
        writer.WriteLine("Đây là dòng thứ nhất");
        writer.WriteLine("Đây là dòng thứ hai");
        writer.WriteLine("Đây là dòng thứ ba");
        writer.Close();

        BinaryWriter bWriter = new BinaryWriter(new FileStream("data.bin", FileMode.Create));
        for (byte i = 48; i < 58; i++)
        {
            bWriter.Write(i);
        }

        for (byte i = 65; i < 91; i++)
        {
            bWriter.Write(i);
        }

        for (byte i = 97; i < 123; i++)
        {
            bWriter.Write(i);
        }

        bWriter.Write("Đây là string");
        bWriter.Close();

        Console.WriteLine(File.ReadAllText("data.bin"));

        var data = File.ReadAllBytes("data.bin");
        foreach (var b in data)
        {
            Console.WriteLine(b);
        }
    }

    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Test1();
        // Test2();
        // Test3();
        Test4();
    }
}