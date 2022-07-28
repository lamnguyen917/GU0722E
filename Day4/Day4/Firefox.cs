namespace CSDay4;

public class Firefox
{
    public string Url; // địa chỉ hiện tại của trình duyệt

    public void Open(string url)
    {
        Url = url;
        Config.SetLastVisit(url);
    }
}