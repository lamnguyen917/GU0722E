namespace CSDay4;

public class Bike
{
    private int _x; // vị trí trục x
    private int _y; // vị trí trục y
    private string _direction = "bac"; // Hướng của của xe

    // In ra console vị trí hiện tại của xe
    public void PrintPosition()
    {
        Console.WriteLine($"Vị trí hiện tại: X={_x}, Y={_y}; hướng đi={_direction}");
    }

    // Quay về phía bên trái
    public void RotateLeft()
    {
        // cấu trúc rẽ nhánh chọn học ở bài 2
        switch (_direction)
        {
            case "bac":
                _direction = "tay";
                break;
            case "nam":
                _direction = "dong";
                break;
            case "dong":
                _direction = "bac";
                break;
            case "tay":
                _direction = "nam";
                break;
            default:
                Console.WriteLine("Hướng đi bị sai");
                break;
        }
    }

    // Quay về hướng bên phải
    public void RotateRight()
    {
        switch (_direction)
        {
            case "bac":
                _direction = "dong";
                break;
            case "nam":
                _direction = "tay";
                break;
            case "dong":
                _direction = "nam";
                break;
            case "tay":
                _direction = "bac";
                break;
            default:
                Console.WriteLine("Hướng đi bị sai");
                break;
        }
    }

    // Tiến về phía trước
    public void Foward()
    {
        // cấu trúc rẽ nhánh chọn học ở bài 2
        switch (_direction)
        {
            case "bac":
                _y++;
                break;
            case "nam":
                _y--;
                break;
            case "dong":
                _x++;
                break;
            case "tay":
                _x--;
                break;
            default:
                Console.WriteLine("Hướng đi bị sai");
                break;
        }
    }
}