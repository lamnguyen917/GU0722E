namespace Day5
{
    namespace chess
    {
        public class Rook : Chess
        {
            public Rook(string name) : base(name)
            {
            }

            public override void Move()
            {
                Y++;
            }
        }
    }
}