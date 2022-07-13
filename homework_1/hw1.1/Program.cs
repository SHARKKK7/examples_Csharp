internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("a = ");
        string? InputNumberA = Console.ReadLine();

        Console.Write("b = ");
        string? InputNumberB = Console.ReadLine();

        if(InputNumberA != null && InputNumberB != null)
        {
            Console.Clear();
            
            int NumberA = int.Parse(InputNumberA);
            int NumberB = int.Parse(InputNumberB);
            int Max;
            
            if(NumberA > NumberB)
            {
                Max = NumberA;
            }

            else
            {
                Max = NumberB;
            }
           
            Console.WriteLine("max = "+Max);
        }
    }
}