internal partial class Program
{
    private static void Main(string[] args)
    {

        void printAnswer(int number)
        {
            if (number == 1) Console.WriteLine("Допустимо: x > 0, y > 0");
            if (number == 2) Console.WriteLine("Допустимо: x < 0, y > 0");
            if (number == 3) Console.WriteLine("Допустимо: x < 0, y < 0");
            if (number == 4) Console.WriteLine("Допустимо: x > 0, y < 0");
        }

        string? inputNumber = Console.ReadLine();

        if (inputNumber != null)
        {
            int numberA = int.Parse(inputNumber);

            printAnswer(numberA);
        }

    }
}