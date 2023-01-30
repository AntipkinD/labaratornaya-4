internal class Program
{
    private static void Main(string[] args)
    {
        int maxLength = 1000;
        var counter = new int[maxLength];

        for (int N = int.Parse(Console.ReadLine()); N > 0; N--)
            counter[int.Parse(Console.ReadLine())]++;
    }
}