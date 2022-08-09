using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapDay5.Bai3

{
    internal class Teacher : Person
    {
        //Tạo lớp Student và Teacher kế thừa lớp Person        //Lớp Teacher có method “Explain”, in ra “bat dau buoi hoc”.
        public Teacher(): base() { }


        public Teacher(string name) : base(name)
        {
        }


        public void Explain()
        {
            Console.WriteLine("Bắt đầu buổi học");
        }

    }
}
