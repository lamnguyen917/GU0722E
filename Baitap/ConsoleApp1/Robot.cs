using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Nen đặt tên file chứa class cùng tên với teen class
    class Robot
    {
        public int pos_x = 0;
        public int pos_y = 0;
        public string name;
        public string color;

        public void forward()
        {
            pos_y += 1;
            Console.WriteLine($"{name} tien len.");
        }

        public void ForwardMultipleTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                forward();
            }
        }

        public void fallback()
        {
            pos_y -= 1;
            Console.WriteLine($"{name} lui lai.");
        }

        public void FallbackMultipleTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                fallback();
            }
        }

        public void move_right()
        {
            pos_x += 1;
            Console.WriteLine($"{name} sang phai");
        }

        public void MoveRightMultipleTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                move_right();
            }
        }

        public void move_left()
        {
            pos_x -= 1;
            Console.WriteLine($"{name} sang trai");
        }

        public void MoveLeftMultipleTimes(int count)
        {
            for (int i = 0; i < count; i++)
            {
                move_left();
            }
        }

        public void set_starting_pos(int x, int y)
        {
            pos_x = x;
            pos_y = y;
        }

        public string GetPosition()
        {
            return $"({pos_x},{pos_y})";
        }

        public void print_robot_cur_position()
        {
            Console.WriteLine($" {name} Position is {GetPosition()}");
            //return [pos_x, pos_y];
        }

        public static void CheckCollision(Robot a, Robot b)
        {
            if (a.pos_x == b.pos_x && a.pos_y == b.pos_y)
            {
                Console.WriteLine($"Da co va cham xay ra giua 2 robot tai vi tri {a.GetPosition()}");
                return;
            }

            Console.WriteLine(
                $"- Khong co va cham xay ra! {a.name}{a.GetPosition()} ; {b.name}{b.GetPosition()}"
            );
        }
    }
}