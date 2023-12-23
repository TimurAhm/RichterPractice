internal class Program
{
    private static int s_n = 2;

    private static void M(Int32 x = 9, String s = "A", DateTime dt = default(DateTime), Guid guid = new Guid())
    {
        Console.WriteLine("x = {0}, s = {1}, dt = {2}, guid = {3}", x, s, dt, guid);
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("1:");
        M();

        Console.WriteLine("2:");
        M(8, "X");

        Console.WriteLine("3:");
        M(5, guid: Guid.NewGuid(), dt: DateTime.Now);

        Console.WriteLine("4:");
        M(++s_n, s_n++.ToString());

        Console.WriteLine("5:");
        M(s: (--s_n).ToString(), x: s_n++);
    }
}

// public static implicit operator
// public static explicit operator
