//#############################################################################################################
//№19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//#############################################################################################################
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите 5-значное число: ");
        string? inputLine = Console.ReadLine(); //считывание данных пользователя с консоли

        int inputNumber = int.Parse(inputLine);

        if ((inputNumber < 99999) && (inputNumber > 10000)) //проверка на правильность входных данных
        {
            Dictionary<int, string> palindrom = new Dictionary<int, string>(); // новый словарь палиндромов

            //метод добавления палиндромов в словарь
            void palindromMaker(Dictionary<int, string> palindrom)
            {
                int n;
                int s = 10;
                //генерация палиндромов 4-х значных чисел
                while (s < 100)
                {
                    n = s * 100 + (s % 10) * 10 + s / 10;
                    palindrom.Add(n, n.ToString());
                    s++;
                }
            }

            palindromMaker(palindrom); //метод занесения в словарь палиндромов

            string inputString = inputNumber.ToString();
            inputString = inputString.Remove(2, 1);
            int palinomNum = int.Parse(inputString);

            //inputNumber = (inputNumber / 1000) * 100 + inputNumber % 100; // еще один вариант удаления среднего числа в палиндроме

            if (palindrom.ContainsKey(palinomNum)) //сверяем значения из словаря и нашего числа
            {
                Console.WriteLine("Палиндром");
            }
            else Console.WriteLine("Не палиндром");

        }
        else Console.WriteLine("Вы ввели не 5-значное число");
    }
}