using System.Diagnostics.Metrics;

internal class Program
{
    int maxLength = 1000;
    private static void Main(string[] args)
    {
        var counter = new int[maxLength];

        for (int i = Convert.ToInt32(Console.ReadLine()); i > 0; i--)
            counter[Convert.ToInt32(Console.ReadLine())]++;

        for (int j = 0; j < counter.Length; j++)
        {
            if (counter[j] != 0)
                Console.WriteLine($"{j} {counter[j]}");
        }
    }
}