using System;
internal class Program
{
    private static void Main(string[] args)
    {
        string? InputLine = Console.ReadLine();

        if(InputLine != null)
        {
            Console.Clear();
            int InputNumber = int.Parse(InputLine);
            int OutNumber = (int)Math.Pow(InputNumber, 6); //InputNumber * InputNumber;

            Console.Write(OutNumber);
        }
    }
}