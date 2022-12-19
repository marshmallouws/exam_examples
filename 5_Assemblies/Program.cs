using System.Reflection;

public class Test
{
    [Obsolete("method1 is obsolete", true)]
    public static int TestAttr()
    {
        return 1;
    }

    static void Main(string[] args)
    {

        long longtest = 1;
        
        int inttest = 1; // = TestAttr();

        Console.WriteLine($"Type of long: {longtest.GetType()}, type of int {inttest.GetType()}");


        Assembly info = typeof(string).Assembly;
        Console.WriteLine(info);
    }
}