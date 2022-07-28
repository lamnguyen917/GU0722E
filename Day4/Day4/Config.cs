namespace CSDay4;

// Class config lưu lại cấu hình của phần mềm
public class Config
{
    public static string SearchEngine = "Google"; // đây là dùng trang tìm kiếm mặc định
    public static string LastVisit = ""; // đây là trang web truy cập gần nhất

    public static void SetLastVisit(string url)
    {
        LastVisit = url;
    }
}