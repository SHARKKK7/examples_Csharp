internal partial class Program
{
    private static void Main(string[] args)
    {
        string? inputLine = Console.ReadLine();

        int numberN = int.Parse(inputLine);
        string lineN = "";
        string lineNN = "";
        int s = 1;

        while(s <= numberN)
        {
            lineN =lineN+s+" ";
            lineNN=lineNN+(int)Math.Pow(s,2)+",";
            s++;
        }

        Console.WriteLine(lineN);
        Console.WriteLine(lineNN);
    }
}