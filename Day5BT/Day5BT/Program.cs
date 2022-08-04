using System.Text;
using Day5BT.Bai1;

namespace Day5BT;

class Program
{
    static void DemoBai1()
    {
        const string Toan = "Toán cao cấp";
        const string Triet = "Triết học";
        // Tạo danh sách 5 sinh viên
        Student[] students = new[]
        {
            new Student(1, "Anh", "1A", "Nam", 6),
            new Student(2, "Bình", "1A", "Nữ", 6),
            new Student(3, "Cường", "1A", "Nam", 9),
            new Student(4, "Dũng", "1A", "Nam", 10),
            new Student(5, "Dương", "1A", "Nữ", 5),
        };
        // In thông tin 5 sinh viên
        for (int i = 0; i < students.Length; i++)
        {
            students[i].PrintInfo();
        }

        Console.WriteLine("================================");
        Student student1 = students[0];
        student1.SetName("Việt Anh");
        student1.SetScore(8);
        student1.PrintInfo();
        student1.SetScore(new[] { 7f, 6f, 7f, 9f, 5f, 3f });
        student1.PrintInfo();
        student1.SetScore(new[] { 4f, 4.5f, 8.5f, 2f });
        student1.PrintInfo();
        Console.WriteLine("================================");

        var student3 = students[2];
        student3.PrintInfo();
        student3.SetScore(Toan, 7);
        student3.SetScore(Triet, 5);
        student3.PrintScores();
        student3.PrintInfo();

        Console.WriteLine("================================");
        students[0].SetScore(Toan, 8);
        students[0].SetScore(Triet, 6);
        
        students[1].SetScore(Toan, 7);
        students[1].SetScore(Triet, 7);
        
        students[2].SetScore(Toan, 10);
        students[2].SetScore(Triet, 5);
        
        students[3].SetScore(Toan, 6);
        students[3].SetScore(Triet, 8);
        
        students[4].SetScore(Toan, 7);
        students[4].SetScore(Triet, 9);
        
        
        // In thông tin 5 sinh viên
        for (int i = 0; i < students.Length; i++)
        {
            students[i].PrintInfo();
        }
    }

    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        DemoBai1();
    }
}