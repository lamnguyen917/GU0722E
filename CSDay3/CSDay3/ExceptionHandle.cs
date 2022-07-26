namespace CSDay3;

public class ExceptionHandle
{
    public static void TestThrow(int a)
    {
        if (a == 10)
        {
            throw new Exception("a khong the bang 10");
        }

        Console.WriteLine("Gia tri cua a la: " + a);
    }

    public static void TestThrow2(int a)
    {
        TestThrow(a);
    }
}