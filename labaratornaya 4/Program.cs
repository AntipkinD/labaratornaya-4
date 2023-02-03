using System.Diagnostics.Metrics;

internal class Program
{
    const int maxLength = 10000;
    static void Main(string[] args)
    {
        var counter = new int[maxLength];

        for (int i = Convert.ToInt32(Console.ReadLine()); i > 0; i--)
            counter[Convert.ToInt32(Console.ReadLine())]++;

        for (int j = 0; j < 3; j++)
        {
            if (counter[j] != 0)
                Console.WriteLine($"{j} {counter[j]}");
        }
    }
}