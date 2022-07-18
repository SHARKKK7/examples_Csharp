internal partial class Program
{
    static void Main(string[] args)
    {
        void example1()
        {
            int numberMaker = new Random().Next(100, 1000);
            Console.WriteLine("Ваше случайное число - " + numberMaker);

            int n1 = numberMaker / 100; //первая числа 3-х значного числа
            int n2 = numberMaker % 10; //последняя цифра числа (остаток от деления)

            int result = n1 * 10 + n2;

            Console.WriteLine(result);
        }

        void example2()
        {
            int numberMaker = new Random().Next(100, 1000);
            Console.WriteLine("Ваше случайное число - " + numberMaker);

            string stringNum = numberMaker.ToString();
            Console.Write(stringNum[0]);
            Console.Write(stringNum[2]);
        }
        
        example1();
        example2();
    }
}