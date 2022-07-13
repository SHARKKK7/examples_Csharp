using System;
internal class Program
{
    private static void Main(string[] args)
    {   
        Console.WriteLine("Является ли первое число квадратом второго? ");
        string? InputNumberA = Console.ReadLine();
        string? InputNumberB = Console.ReadLine();

        if(InputNumberA != null && InputNumberB != null)
        {   
            //Console.Clear();
            int NumberA = int.Parse(InputNumberA);
            int NumberB = int.Parse(InputNumberB);
            //int OutNumber = (int)Math.Pow(InputNumberB, 2); //InputNumber * InputNumber;

            if (Math.Sqrt(NumberB) == NumberA)
            {
                Console.WriteLine("Да");
            }

            else
            {
                Console.WriteLine("Нет");
            }
                
        }
    }
}