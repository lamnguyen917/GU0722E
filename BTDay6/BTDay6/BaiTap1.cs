using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace BTDay6
{
    class BaiTap1
    {
        static int total = 0;
        TimeSpan total_time = new TimeSpan();


        public void using_1_threading()
        {
            total = 0;
            
            Thread thread = new Thread(calculate_total_from_1_to_1mil);
            thread.Start();
            //Program.Print("using_1_threading");
            thread.Join();
           
            Program.Print("Phép toán tổng từ 1 đến 1 triệu là " + total);
        }

        public void using_4_threadings()
        {
            total = 0;
            
            Thread thread1 = new Thread(calculate_total_from_1_to_250000);
            Thread thread2 = new Thread(calculate_total_from_250001_to_500000);
            Thread thread3 = new Thread(calculate_total_from_500001_to_750000);
            Thread thread4 = new Thread(calculate_total_from_750001_to_1000000);
            //Program.Print("using_4_threadings");
            thread1.Start();
            thread1.Join();
            thread2.Start();
            thread2.Join();
            thread3.Start();
            thread3.Join();
            thread4.Start();
            thread4.Join();
            Program.Print($"Tổng thời gian threading thực hiện là {total_time} ");
            Program.Print("Phép toán tổng từ 1 đến 1 triệu là " + total);


        }

        public void calculate_total_from_1_to_1mil()
        {
            
            Stopwatch w = new Stopwatch();
            w.Start();
            total = PhepToanTong(1, 1000000);
            w.Stop();
           
            Program.Print($"Tổng thời gian threading thực hiện là {w.Elapsed} ");
        }




        public void calculate_total_from_1_to_250000()
        {
            Stopwatch w = new Stopwatch();
            w.Start();
            total += PhepToanTong(1, 250000);
            //Program.Print("Phep tinh: " + total);
            w.Stop();
            total_time += w.Elapsed;
            Program.Print($"Thời gian threading thực hiện là {w.Elapsed} ");
        }
        public void calculate_total_from_250001_to_500000()
        {
            Stopwatch w = new Stopwatch();
            w.Start();
            total += PhepToanTong(250001, 500000);
            //Program.Print("Phep tinh calculate_total_from_250001_to_500000: " + total);
            w.Stop();
            total_time += w.Elapsed;
            Program.Print($"Thời gian threading thực hiện là {w.Elapsed} ");
        }
        public void calculate_total_from_500001_to_750000()
        {
            Stopwatch w = new Stopwatch();
            w.Start();
            total += PhepToanTong(500001, 750000);
            //Program.Print("Phep tinh: " + total);
            w.Stop();
            total_time += w.Elapsed;
            Program.Print($"Thời gian threading thực hiện là {w.Elapsed} ");
        }
        public void calculate_total_from_750001_to_1000000()
        {
            Stopwatch w = new Stopwatch();
            w.Start();
            total += PhepToanTong(750001, 1000000);
            //Program.Print("Phep tinh: " + total);
            w.Stop();
            total_time += w.Elapsed;
            Program.Print($"Thời gian threading thực hiện là {w.Elapsed} ");
        }





        static int PhepToanTong(int starter_number, int to_number)
        {
            int result = 0;
            for (int i = starter_number; i <= to_number; i++)
            {
                result += i;
            }
            return result;

        }

        


    }
}
