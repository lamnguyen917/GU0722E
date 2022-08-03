namespace Day5;

public abstract class Vehicle
{
    public int SeatNumber;
    public int WheelNumber;

    private float _maxSpeed = 100;

    private float _speed;

    public abstract void GetFuel();

    public void Start()
    {
        _speed = 100;
        Console.WriteLine("Khởi động xe");
    }

    public void Stop()
    {
        _speed = 0;
        Console.WriteLine("Dừng xe");
    }

    public void SetSpeed(float speed)
    {
        if (speed < 0)
        {
            throw new Exception("Speed không thể < 0");
        }

        if (speed > _maxSpeed)
        {
            throw new Exception($"Speed không thể vượt quá {_maxSpeed}");
        }

        _speed = speed;
    }

    public void PrintStatus()
    {
        Console.WriteLine($"Seat={SeatNumber}, Wheel={WheelNumber}, Speed={_speed}, Max Speed={_maxSpeed}");
    }
}