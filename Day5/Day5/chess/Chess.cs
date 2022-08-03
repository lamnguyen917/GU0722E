namespace Day5
{
    namespace chess
    {
        public abstract class Chess : Auditable
        {
            protected string _color = "BLACK";

            public int X;
            public int Y;

            public string Name;
            public abstract void Move();

            public Chess(string name)
            {
                Name = name;
            }

            public void Eat(Chess chess)
            {
                Console.WriteLine($"Quân cờ {Name} đã bắt quân cờ {chess.Name}");
            }

            public void PrintStatus()
            {
                Console.WriteLine($"X={X}, Y={Y}, color={_color}");
            }
        }
    }
}