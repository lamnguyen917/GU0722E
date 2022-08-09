using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaiTapDay5.Bai1;

namespace BaiTapDay5.Bai2
{
    class ITStudent : Student
    {
        //Tạo lớp ITStudent kế thừa lớp Student.
        //Tạo constructor có tham số và ko có tham số để khởi tạo các trường tương ứng
        public ITStudent() { }
        public ITStudent(string _name, string _class_name, string _gender, float _score) 
        {
            //Readonly ID
                //id = _id;
            name = _name;
            class_name = _class_name;
            gender = _gender;
            score = _score;
        }

        //Ghi đè lên lớp SetScore, với điểm trung bình nhỏ hơn 5.5 thì sẽ cảnh cáo
        public void SetScore(float[] scores)
        {
            Console.WriteLine("Ghi đè lên lớp SetScore, với điểm trung bình nhỏ hơn 5.5 thì sẽ cảnh cáo");
            float total = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                total += scores[i];
            }
            score = total / scores.Length;
            Console.WriteLine($"Điểm số trung bình của học viên {name} là: {score}");
            if (score < 5.5f)
            {
                Console.WriteLine("!!!!!Điểm trung bình của học viên này dưới 5.5!!!!!");
            }
        }
    }
}
