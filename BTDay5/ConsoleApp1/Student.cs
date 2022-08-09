using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapDay5.Bai3
{
    class Student : Person
    {
        //Tạo lớp Student và Teacher kế thừa lớp Person        public Student(string name)  :base(name)
        {

        }


        public void GoToClasses()
        {
            Console.WriteLine("Tôi đi học");
        }

        //Student có method ShowAge, in ra tuổi của sinh viên 
        public void ShowAge()
        {
            Console.WriteLine($"Tuổi của tôi là: {Age}");
        }

        public void ShowName()
        {
            Console.WriteLine($"Tên tôi là: {Name}");
        }

    }
}
