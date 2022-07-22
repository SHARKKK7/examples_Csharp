//#############################################################################################################################
//№21 1 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//#############################################################################################################################
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число: ");

        string cubeLine = Console.ReadLine();

        int cube = int.Parse(cubeLine);

        // метод подсчета кубов чисел
        void Cube(int[] cube)
        {
            int counter = 0;
            int s = 0;
            int length = cube.Length;
            string lineN = " ";
            while (counter < length)
            {
                lineN = lineN + s + " ";
                cube[counter] = (int)Math.Pow(counter, 3);
                counter++;
                s++;
            }
            Console.WriteLine(lineN); // вывод в строку чисел от 1 до N
        }

        //метод вывода кубов чисел с пробелами
        void PrintArray(int[] coll)
        {
            int count = coll.Length;
            int index = 0;
            while (index < count)
            {
                Console.Write(coll[index] + " ");
                index++;
            }
        }

        int[] array = new int[cube + 1];
        Cube(array);
        PrintArray(array);
    }
}

