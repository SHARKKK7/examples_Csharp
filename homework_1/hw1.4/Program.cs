internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" ");
        string? InputLine = Console.ReadLine();

        if (InputLine != null)
        {
            Console.Clear();

            int N = int.Parse(InputLine);
    
            int NumberB = 2;
            string LineOutput = "";

           
            while(NumberB <= N-2)
            {
                LineOutput = LineOutput+NumberB+", ";
                NumberB=NumberB+2;
        
            }
            LineOutput=LineOutput+(NumberB);
            Console.WriteLine(LineOutput);
        }
    }
}