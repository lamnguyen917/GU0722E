using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapDay5.Bai3
{
    class RunBai3
    {
        Teacher teacher = new Teacher();
        
        Student[] students = new[]
        {
            new Student("Mạnh"),
            new Student("Duy"),
            new Student("Dũng"),
            new Student("Trung"),
            new Student("Hảo"),
        };
        
        public void set_students_age()
        {
            students[0].SetAge(21);
            students[1].SetAge(23);
            students[2].SetAge(26);
            students[3].SetAge(22);
            students[4].SetAge(28);
        }

        public void let_students_introduce()
        {
            StudentAndTeacherTest test = new StudentAndTeacherTest();
            test.Main();
            foreach (var student in students)
            {
                Console.WriteLine("--------------------------------------------");
                
                student.ShowName();
                student.ShowAge();
                student.GoToClasses();
            }

            teacher.Explain();

        }
        
        






    }
}
