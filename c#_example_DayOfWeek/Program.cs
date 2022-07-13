internal partial class Program
{
    private static void Main(string[] args)
    {
        string? InputLine = Console.ReadLine();

        if(InputLine != null)
        {
            int InputNumber = int.Parse(InputLine);

            switch (InputNumber) //вариант через switch/case
            {
                case 1: Console.WriteLine("monday");
                break;

                case 2: Console.WriteLine("sunday");
                break;

                case 3: Console.WriteLine("thirday");
                break;

                case 4: Console.WriteLine("thuesday");
                break;

                case 5: Console.WriteLine("friday");
                break;

                case 6: Console.WriteLine("saturday");
                break;

                case 7: Console.WriteLine("wendsday");
                break;

            }
            // string[] Week = new string[7]; //реализация через массив
            // Week[0] = "monday";
            // Week[1] = "sunday";
            // Week[2] = "thirday";
            // Week[3] = "thuesday";
            // Week[4] = "friday";
            // Week[5] = "saturday";
            // Week[6] = "wendsday";

            //Console.WriteLine(Week[InputNumber-1]);
        }
    }
}