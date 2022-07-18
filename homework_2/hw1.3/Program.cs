internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Является ли введеный день выходным?");
        Console.WriteLine("Укажите день недели от 1-7: ");
        string? InputNumber = Console.ReadLine();

        if (InputNumber != null)
        {
            int number = int.Parse(InputNumber);

            if (number <= 7) //проверка корректности введеных данных относительно кол-ва дней недели
            {
                if ((number == 6) || (number == 7)) //проверка условия задачи
                {
                    Console.WriteLine("Да");
                }
                else Console.WriteLine("Нет");
            }
            else Console.WriteLine("Неверно указан день недели");
        }
    }
}