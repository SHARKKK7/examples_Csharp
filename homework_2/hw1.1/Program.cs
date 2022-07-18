internal partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите трёхзначное число:");
        string? InputNumber = Console.ReadLine();

        void example()
        {
            if (InputNumber != null)
            {
                int number = int.Parse(InputNumber);

                if (number > 99 && number <= 999) //проверка на вводимое трёхзначное число
                {
                    string stringNum = number.ToString(); //преобразуем число в строку
                    Console.Write("Вторая цифра числа - " + stringNum[1]); //выводим 2 элемент строки

                }
                else Console.WriteLine("Вы ввели не трёхзначное число, попробуйте еще раз");
            }
        }

        example(); //вызов метода
    }
}
