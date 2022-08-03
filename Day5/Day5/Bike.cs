namespace Day5;

public class Bike : Vehicle
{
    public Bike()
    {
        SeatNumber = 2;
        WheelNumber = 2;
    }

    public override void GetFuel()
    {
        Console.WriteLine("Đổ xăng cho xe máy");
    }
}