internal partial class Program
{
    static void Main(string[] args)
    {

        System.Random numberMaker = new Random();

        //Метод решения задачи первым вариантом
        void example1(System.Random numberMaker)
        {
            //Вариант 1
            int number = numberMaker.Next(10, 100);
            Console.Clear();

            Console.WriteLine(number);

            int firstnumber = number / 10;
            int secondnumber = number % 10;

            if (firstnumber > secondnumber)
            {
                Console.WriteLine(firstnumber);
            }
            else Console.WriteLine(secondnumber);

        }

        //Метод решения задачи вторым вариантом
        void example2()
        {
            //Вариант 2
            int number = new Random().Next(10, 100);

            Console.Write("Ваше число: ");
            Console.WriteLine(number);

            string stringNum = number.ToString();

            Console.Write("Большая часть числа - ");
            if (stringNum[0] > stringNum[1])
            {
                Console.WriteLine(stringNum[0]);
            }

            else Console.WriteLine(stringNum[1]);
        }

        //Метод решения задачи третьим вариантом
        void example3(System.Random numberMaker)
        {
            //Вариант 3
            //System.Random numberMaker = new Random();

            char[] digits = numberMaker.Next(10, 100).ToString().ToCharArray();
            Console.WriteLine(digits);


            int firstNumber = ((int)digits[0] - 48);
            int secondNumber = ((int)digits[1] - 48);

            int resultNumber = firstNumber > secondNumber ? resultNumber = firstNumber : resultNumber = secondNumber;
            Console.WriteLine(resultNumber);
        }

        //example1(numberMaker);

        example2();

        example3(numberMaker);
    }
}