internal partial class Program
{
    private static void Main(string[] args)
    {

        string? InputLine = Console.ReadLine();
        string? InputLine1 = Console.ReadLine();
        string? InputLine2 = Console.ReadLine();
        


        if (InputLine != null && InputLine1 != null && InputLine2 != null)
        {
            Console.Clear();

            int NumberA = int.Parse(InputLine);
            int NumberB = int.Parse(InputLine1);
            int NumberC = int.Parse(InputLine2);
            int Max;
            //int max = Math.Max(NumberA, Math.Max(NumberB, NumberC));

            if(NumberA > NumberB)
            {
                Max = NumberA;

                if(NumberA > NumberC) Max = NumberA;
                else Max = NumberC;
            }

            else
            {
                Max = NumberB;

                if(NumberB > NumberC) Max = NumberB;
                else Max = NumberC;
            }

            Console.WriteLine(Max);
        }
    }
}