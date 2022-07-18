internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        string? InputNumber = Console.ReadLine();

        if (InputNumber != null)
        {
            int numberA = int.Parse(InputNumber);
            string stringNum = numberA.ToString(); //преобразуем число в строку

            if (stringNum.Length >= 3) //проверка есть ли у строки 3 элемент
            {
                Console.WriteLine(stringNum[2]); //вывод 3 элемента если он есть
            }
            else Console.WriteLine("Третьей цифры нет");

        }
    }
}