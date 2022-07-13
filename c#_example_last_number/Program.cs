internal partial class Program
{
    private static void Main(string[] args)
    {
        string? InputLine = Console.ReadLine();

        if(InputLine != null)
        {
            Console.Clear();
            char[] M = InputLine.ToCharArray(); 
            Console.WriteLine(M[2]);


            // //int Number = int.Parse(InputLine);
            // string? NUMB = InputLine.Substring(2,1);
            // //int N = Number % 10;

            // Console.WriteLine(NUMB);
            
        }
    }
}