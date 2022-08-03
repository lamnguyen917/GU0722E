namespace Day5
{
    namespace chess
    {
        public class Bishop : Chess
        {

            internal string internalVariable = "IIIIIIIIIIIIIIIIII";
            public override void Move()
            {
                X++;
                Y++;
            }

            public Bishop(string name) : base(name)
            {
                _color = "WHITE";
            }
        }
    }
}
