using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using BaiTapDay5.Bai1;


namespace BaiTapDay5.Bai1

{
    class RunBai1
    {

        // Tạo danh sách 5 sinh viên và in ra thông tin 5 sinh viên đó
        public Student[] students = new[]
        {
            new Student(1, "Anh", "1A", "Nam", 6),
            new Student(2, "Bình", "1A", "Nữ", 6),
            new Student(3, "Cường", "1A", "Nam", 9),
            new Student(4, "Dũng", "1A", "Nam", 10),
            new Student(5, "Dương", "1A", "Nữ", 5),
        };

       


        public void _print_5_students_info()
        {
            
            Console.WriteLine("//In thông tin 5 sinh viên");
            for (int i = 0; i < students.Length; i++)
            {
                students[i].print_student_info();
            }

        }

        public void _change_student_info()
        {
            Student student = students[0];
            student.set_name("Vân Anh");
            student.set_score(6);
            student.set_gender("Nữ");
            student.print_student_info();
        }

        public void _create_subjects_scores_for_students()
        {
            const string TRIET = "Triết học";
            const string TOAN = "Toán cao cấp";
            Student student1 = students[0];
            student1.set_subject_score(TRIET, 8);
            student1.set_subject_score(TOAN, 8);
            student1.print_student_subjects_scores();
            Student student2 = students[1];
            student2.set_subject_score(TRIET, 6);
            student2.set_subject_score(TOAN, 4);
            student2.print_student_subjects_scores();

            Student student3 = students[2];
            student3.set_subject_score(TRIET, 9);
            student3.set_subject_score(TOAN, 7);
            student3.print_student_subjects_scores();

            Student student4 = students[3];
            student4.set_subject_score(TRIET, 9);
            student4.set_subject_score(TOAN, 8);
            student4.print_student_subjects_scores();


            Student student5 = students[4];
            student5.set_subject_score(TRIET, 8);
            student5.set_subject_score(TOAN, 8);
            student5.set_subject_score("Tiếng Anh", 10);
            student5.print_student_subjects_scores();


        }



        public void set_exist_student_multi_scores(string name, float[] scores)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].get_name == name)
                {
                    students[i].SetScore(scores);

                    return;
                }
            }
            Console.WriteLine($"Không có học viên tên là {name} trong lớp!");
        }




        
    }
}
