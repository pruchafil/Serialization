using System;

namespace Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        Starter r = new();
        r.Run();

        while (true)
            Console.ReadKey();
    }
}
