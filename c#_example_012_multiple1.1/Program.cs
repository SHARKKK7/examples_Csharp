internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        string? InputNumber = Console.ReadLine();


        if (InputNumber != null)
        {
            Console.Clear();
            int numberA = int.Parse(InputNumber);
            int numberB = numberA % 7;
            int numberC = numberA % 23;

            if ((numberB == 0) && (numberC == 0))
            {
                Console.WriteLine("Да");
            }
            else Console.WriteLine("Нет");

        }
    }
}