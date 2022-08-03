namespace Day5;

public class Bicycle : Vehicle
{
    public override void GetFuel()
    {
        Console.WriteLine("Không thể đổ xăng cho xe đạp");
    }
}