using static OddEvenApp.NumberHelper;
namespace OddEvenApp;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        Print("Numbers: ", numbers);
        Print("Even: ", numbers.Where(x => NumberHelper.IsEven(x)));
        Print("Odd: ", numbers.Where(x => NumberHelper.IsOdd(x)));
    }
    public static void Print(string text, IEnumerable<int> numbers)
    {
        Console.Write(text);
        Console.Write("[ ");
        foreach(int number in numbers)
        {
            Console.Write($" {number}");
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
}
