using System.Collections.Immutable;

namespace CSDay2
{
    class Program
    {
        // Giải bài 1 buổi 2 dùng vòng lặp
        static void Bai1()
        {
            int save1 = 0;
            int save2 = 0;
            int fi = 0;
            for (int i = 1; i <= 15; i++)
            {
                if (i == 1)
                {
                    fi = 1;
                }
                else if (i == 2)
                {
                    fi = 1;
                }
                else
                {
                    fi = save1 + save2;
                }

                Console.WriteLine($"save2={save2}, save1={save1}, fi={fi}");
                save2 = save1;
                save1 = fi;
            }

            Console.WriteLine("So Fibonaci thu 15 la " + fi);
        }

        // Giải bài 1 buổi 2 dùng đệ quy
        static int Fi(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 1;
            return Fi(n - 1) + Fi(n - 2);
        }

        static void Bai2()
        {
            Dictionary<string, float> bangDiem = new Dictionary<string, float>
            {
                { "Ha", 22.5f },
                { "Hung", 21.5f },
                { "Lan", 26.75f },
                { "Tuan", 22.75f },
                { "Tu", 19.5f },
                { "Dat", 23.0f },
                { "Tung", 24.5f },
                { "Phuong", 28.75f },
                { "Cuong", 25.5f },
                { "Thanh", 20.5f },
            };

            float tongDiem = 0;

            // In danh sach bang diem theo thu tu diem tu thap toi cao
            foreach (var kv in bangDiem.OrderBy(kv => kv.Value))
            {
                Console.WriteLine(kv.Key + " : " + kv.Value);
            }

            Console.WriteLine("===================================");
            // In danh sach bang diem sap xep theo ten
            foreach (var kv in bangDiem.OrderBy(kv => kv.Key))
            {
                Console.WriteLine(kv.Key + " : " + kv.Value);
            }
            
            Console.WriteLine("===================================");
            foreach (var kv in bangDiem)
            {
                var ten = kv.Key;
                if (ten[0] == 'T' || ten[0] == 't')
                {
                    Console.WriteLine("Ten ban co van T la: " + ten);
                    tongDiem += kv.Value;
                }
            }

            Console.WriteLine("Tong diem cua cac ban ten co van T la " + tongDiem);
        }

        static void Main(string[] args)
        {
            // Chạy test bài 1 buổi 2 dùng vòng lặp
            // Bai1();
            // Chạy test bài 1 buổi 2 dùng đệ quy
            // int fi = Fi(15);
            // Console.WriteLine("So Fibonaci thu 15 la " + fi);

            Bai2();
        }
    }
}