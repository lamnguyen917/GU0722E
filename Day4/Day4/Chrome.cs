namespace CSDay4;

public class Chrome
{
    public string Url; // địa chỉ hiện tại của trình duyệt

    public void Open(string url)
    {
        Url = url;
        Config.LastVisit = url;
    }
}
