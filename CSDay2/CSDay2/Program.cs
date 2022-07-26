using System.Collections.Immutable;

namespace CSDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tuan";
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
            
            foreach (var kv in bangDiem)
            {
                var ten = kv.Key;
                if (ten[0] == 'T' || ten[0] == 't')
                {
                    tongDiem += kv.Value;
                }
            }
            
            Console.WriteLine("Tong diem cua cac ban ten co van T la " + tongDiem);
        }
    }
}