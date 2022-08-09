using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapDay5.Bai3
{
    public class Person
    {

        protected int Age ;
        protected string Name;

        //Tạo lớp Person với constructor.        public Person() { }
        public Person(string name)
        {
            Name = name;
            
        }                //Class Person có một method SetAge, để set biến Age của nó
        public void SetAge(int _age)
        {
            Age = _age;
           
        }

    }
}
