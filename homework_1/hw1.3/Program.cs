internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Является ли число четным? ");
        string? InputLine = Console.ReadLine();

        if (InputLine != null)
        {
            Console.Clear();

            int Number = int.Parse(InputLine);
    
            int result = Number % 2;

            if(result == 0)
            {
                Console.WriteLine("Да");
            }

            else Console.WriteLine("Нет");
        }
    }
}