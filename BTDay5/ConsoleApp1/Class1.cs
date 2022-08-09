using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapDay5.Bai1

{
    public class Student
    {
        // Tạo lớp Student có các biến id, name, class, gender, score.
        protected readonly int id;
        protected string name;
        protected string class_name;
        protected string gender;
        protected float score;

        // Tạo constructor có tham số và ko có tham số để khởi tạo các trường tương ứng
        public Student()
        {
        }
        public Student(int id, string name, string class_name, string gender, float score)
        {
            this.id = id;
            this.name = name;
            this.class_name = class_name;
            this.gender = gender;
            this.score = score;
        }
        // ID để readonly, name, class, gender, score thì cho public get nhưng private set

        public string get_name
        {
            get { return name; }
        }

        public string get_class_name => class_name;
        public string get_gender => gender;
        public float get_score => score;

        public void print_student_info()
        {
            Console.WriteLine($" Tên: {name}, Số ID: , Lớp: {class_name}, Giới tính: {gender}, Điểm số: {score}");
        }

        //Thêm các method cho phép sửa đổi thông tin các tham số sinh viên
        public void set_name(string name)
        {
            this.name = name;
        }
        public void set_class_name(string class_name)
        {
            this.class_name = class_name;
        }
        public void set_gender(string gender)
        {
            this.gender = gender;
        }
        public void set_score ( float score)
        {
            this.score = score;
        }
        //Thêm method SetScore, tham số truyền vào là một collection, set điểm (score) của object là trung bình cộng của collection,         //... in ra thông báo cảnh cáo nếu điểm trung bình cộng đó nhỏ hơn 6.
        public void SetScore(float[] scores)
        {
            float total = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                total += scores[i];
            }
            score = total / scores.Length;
            Console.WriteLine($"Điểm số trung bình của học viên {name} là: {score}");
            if (score < 6f)
            {
                Console.WriteLine("!!!!!Điểm trung bình của học viên này dưới 6!!!!!");
            }
        }

        //Tạo danh sách điểm toán cao cấp, triết học cho các sinh viên trên, in ra thông tin điểm từng sinh viên.
        private Dictionary<string, float> subjects_scores = new Dictionary<string, float>();
        const string TRIET = "Triết học";
        const string TOAN = "Toán cao cấp";
        String[] subjects = new String[2] { TRIET, TOAN };
        
        public void set_subject_score(string subject, float score)
        {
            
            foreach (var _subject in subjects)
            {

                if (subject != _subject)
                {
                    continue;
                }
                subjects_scores[subject] = score;
                return;
            }
            Console.WriteLine($"Không thể tìm thấy môn học {subject}");


        }
        public void print_student_subjects_scores()
        {
            string scoresText = "";
            foreach (var kv in subjects_scores)
            {
                scoresText += $" {kv.Key}:{kv.Value};";
            }

            Console.WriteLine($"ID={id}, Name={name}, Gender={gender}, Score=({scoresText})");
        }
    }
}
