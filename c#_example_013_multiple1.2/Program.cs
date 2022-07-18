internal partial class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Введите число a: ");
        string? InputNumberA = Console.ReadLine();

        Console.WriteLine("Введите число b: ");
        string? InputNumberB = Console.ReadLine();

        if (InputNumberA != null && InputNumberB != null)
        {
            int numberA = int.Parse(InputNumberA);
            int numberB = int.Parse(InputNumberB);
            int squareA = (int)Math.Pow(numberA, 2);
            int squareB = (int)Math.Pow(numberB, 2);
            //Console.WriteLine(result);

            if((numberA == squareB) || (numberB == squareA))
            {
                Console.WriteLine("Число является квадратом другого числа");
            }
            else Console.WriteLine("Число не является квадратом другого числа");
        }
    }
}