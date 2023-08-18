using Anagram.Services;

namespace Anagram;
class Program
{
    static void Main(string[] args)
    {
        IReverter _reverter = new ReverseTextService();
        while (true)
        {
            DoWork(_reverter);
            Console.WriteLine();
        }
    }

    private static void DoWork(IReverter reverter)
    {
        Console.WriteLine("Type here");
        string? data = Console.ReadLine();
        if (data != null)
        {
            Console.WriteLine(reverter.ReverseText(data));
        }
    }
}