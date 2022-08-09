using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BTDay6
{
    class BaiTap2
    {
        public Dictionary<string, string> students_data = new Dictionary<string, string>();
        static string insert;

        //Nhập dữ liệu họ tên, điểm, ngày tháng năm sinh của 10 học viên vào file (nội dung tự nghĩ)
        public void input_students_data_to_file(string file_name)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Hãy nhập tên: ");
                string name = Console.ReadLine();
                Console.Write("Hãy nhập điểm: ");
                string score = Console.ReadLine();
                Console.Write("Hãy nhập ngày/tháng/năm sinh: ");
                string day_month_year = Console.ReadLine();
                Console.WriteLine("");

                students_data.Add(name + day_month_year, name + " - " + score + " - " + day_month_year);
                //Program.Print("check " + students_data[name + day_month_year]);
                Program.Print($"Dữ liệu học sinh thứ {i}: {name} - {score} - {day_month_year}");
            }

            if (File.Exists("test_write.txt"))
            {
                File.Delete("test_write.txt");
            }



            foreach (var data in students_data)
            {
                insert += data.Value + "\n";

            }
            File.WriteAllText(file_name, insert);
           // Program.Print("Insert Data to File successfully! "+ insert);

        }
        public static void read_data_file(string file_name)
        {
            Program.Print("\nIn ra thông tin đó từ file theo thứ tự Họ tên – điểm – ngày tháng năm sinh");
            var content = File.ReadAllLines(file_name);
            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }
        }



    }
}
