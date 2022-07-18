internal partial class Program
{
    static void Main(string[] args)
    {
        Console.Write("а = ");
        string? InputNumberA = Console.ReadLine();
        Console.Write("b = ");
        string? InputNumberB = Console.ReadLine();

        if (InputNumberA != null && InputNumberB != null)
        {
            Console.Clear();
            int numberA = int.Parse(InputNumberA);
            int numberB = int.Parse(InputNumberB);
            int numberC = numberB % numberA; //переменная которая хранит остаток от деления a/b

            if (numberC == 0)
            {
                Console.WriteLine("Кратно");
            }
            else Console.WriteLine("Некратно, остаток от деления - "+numberC);
           
        }
    }
}
