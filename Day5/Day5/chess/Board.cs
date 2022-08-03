namespace Day5
{
    namespace chess
    {
        public class Board
        {
            public Chess[] Piecies = new Chess[]
            {
                new Bishop("Tượng 1"),
                new Bishop("Tượng 2"),
                new Rook("Tốt 1"),
                new Rook("Tốt 2"),
                new Rook("Tốt 3"),
                new Rook("Tốt 4"),
                new Rook("Tốt 5"),
                new Rook("Tốt 6"),
                new Rook("Tốt 7"),
                new Rook("Tốt 8"),
            };

            public Board()
            {
            }

            public void Move(Chess chess)
            {
                chess.Move();
                Console.WriteLine($"Quân cờ {chess.Name} di chuyển đến vị trí ({chess.X},{chess.Y})");
            }

            public void Move(int index)
            {
                if (index >= Piecies.Length)
                {
                    Console.WriteLine("Không có quân cờ này");
                    return;
                }

                Move(Piecies[index]);
            }

            public void PrintStatus()
            {
            }
        }
    }
}
