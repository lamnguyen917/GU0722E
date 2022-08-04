namespace Day5BT.Bai1;

// Bài 1
// Tạo lớp Student có các biến id, name, class, gender, score.
//  1   Tạo constructor có tham số và ko có tham số để khởi tạo các trường tương ứng
//  2   ID để readonly, name, class, gender, score thì cho public get nhưng private set
//  3   Tạo danh sách 5 sinh viên và in ra thông tin 5 sinh viên đó
//  4   Thêm các method cho phép sửa đổi thông tin các tham số sinh viên
//  5   Thêm method SetScore, tham số truyền vào là một collection, set điểm (score) của object là trung bình cộng của collection,
//       in ra thông báo cảnh cáo nếu điểm trung bình cộng đó nhỏ hơn 6.
//  6  Tạo danh sách điểm toán cao cấp, triết học cho các sinh viên trên, in ra thông tin điểm từng sinh viên.
public class Student
{
    // biến có từ khoá readonly thì nó sẽ chỉ được gán 1 lần, sau đó không thể thay đổi giá trị
    private readonly int id;
    private string name;
    private string className;
    public string gender;
    public float score;

    public Dictionary<string, float> scores = new Dictionary<string, float>();

    public Student()
    {
    }

    public Student(int id, string name, string className, string gender, float score)
    {
        this.id = id;
        this.name = name;
        this.className = className;
        this.gender = gender;
        this.score = score;
    }

    // Đây là hàm get, thường được dùng để trả về giá trị của biến private
    public string GetName()
    {
        return name;
    }

    public string Name
    {
        // Đây là getter, thường được dùng để lấy 1 giá trị của biến private, dùng như là một biến của hàm 
        get { return name; }

        // Đây là setter, nhận value là giá trị truyền vào
        // set { name = value + " nhận từ setter"; }
    }

    public string ClassName => className;
    public string Gender => gender;
    public float Score => score;

    // Id là biến readonly, nên chúng ta sẽ không định nghĩa hàm SetID
    // Hàm sửa đổi thông tin cho Name, tương tự cho ClassName, Gender, Score
    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetClassName(string className)
    {
        this.className = className;
    }

    public void SetGender(string gender)
    {
        this.gender = gender;
    }

    public void SetScore(float score)
    {
        this.score = score;
    }

    public void SetScore(string subject, float score)
    {
        scores[subject] = score;
    }

    public void PrintScores()
    {
        foreach (var kv in scores)
        {
            Console.WriteLine($"Điểm {kv.Key} là {kv.Value}");
        }
    }

    public void SetScore(float[] scores)
    {
        float total = 0; // biến để tính tổng điểm truyền vào
        for (int i = 0; i < scores.Length; i++)
        {
            total += scores[i];
        }

        // tính trung bình cộng của các điểm
        score = total / scores.Length;
        if (score < 6f)
        {
            Console.WriteLine("Điểm số không đạt yêu cầu");
        }
    }

    public void PrintInfo()
    {
        string scoresText = "";
        foreach (var kv in scores)
        {
            scoresText += $"{kv.Key}:{kv.Value};";
        }

        Console.WriteLine($"ID={id}, Name={name}, Gender={gender}, Score=({scoresText})");
    }
}