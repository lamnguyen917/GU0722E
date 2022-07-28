namespace CSDay4;

public class Car
{
    // Các thuộc tính, định nghĩa bằng các kiểu dữ liệu, xem ở Slide số 2
    public string Color; // Màu sắc
    public string Maker; // Hãng sản xuất
    public string Model; // tên model xe
    public int PositionX; // Vi tri theo truc X
    public int PositionY; // Vi tri theo truc Y
    
    // thuộc tính private
    private string _thuocTinhAn;

    // Hàm khởi tạo tự định nghĩa
    public Car()
    {
    }

    public Car(string color, string maker, string model)
    {
        Color = color;
        Maker = maker;
        Model = model;
        _thuocTinhAn = "Đây là thuộc tính ẩn";
    }

    // Các phương thức, mô tả hành vi của đối tượng

    // Đây là phương thức sơn màu xe thành màu xanh
    public void PaintBlue()
    {
        Color = "BLUE";
    }

    public void Paint(string color)
    {
        Color = color;
    }

    // In thông tin của xe ra console
    public void PrintProps()
    {
        Console.WriteLine($"Color = {Color}, Maker = {Maker}, Model = {Model}");
    }

    public void CheckVariable(string Color)
    {
        Console.WriteLine($"Màu sắc của xe là {this.Color}");
        Console.WriteLine($"Màu sắc truyền vào là {Color}");
        
        PrintProps();
    }

    // Hàm công khai được khai báo với từ khoá public 
    // hàm công khai thì có thể được truy cập từ bên ngoài class
    // Hàm công khai thì có thể gọi hàm riêng tư
    public void HamCongKhai()
    {
        Console.WriteLine("HÀM PUBLIC");
        
        Console.WriteLine("Gọi hàm private");
        HamRiengTu();
    }

    // Hàm riêng tư được khai báo với từ khoá private
    // hàm riêng tư thì chỉ có thể truy cập trong class, không thể try cập từ bên ngoài
    // hàm riêng tư thì có thể gọi từ hàm công khai
    private void HamRiengTu()
    {
        Console.WriteLine("HÀM PRIVATE");
    }

    public string LayThuocTinhAn()
    {
        return _thuocTinhAn;
    }
}
