internal partial class Program
{
    private static void Main(string[] args)
    {
        string? InputLine = Console.ReadLine();

        if(InputLine != null)
        {
            Console.Clear();
            int N = int.Parse(InputLine);
            int S = 1;
            string LineOutput = "0";
            
            while (S <= N)
            {
                LineOutput = S*(-1)+", "+LineOutput+", "+S;
                S++;
            }

            // string LineOutput = "";

            // while(S < N)
            // {
            //     LineOutput = LineOutput+S+", ";
            //     S++;
            // }

            // LineOutput=LineOutput+N;
            Console.WriteLine(LineOutput);
        }

            
    }
}