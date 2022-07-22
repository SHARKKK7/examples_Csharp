//#############################################################################################################################
//№21 1 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//#############################################################################################################################
internal partial class Program
{
    private static void Main(string[] args)
    {
        // A(3, 6, 8); B(2, 1, -7)
        // A(7, -5, 0); B(1, -1, 9)
      
        string? inputLine = Console.ReadLine();

        // метод который разбивает строку на элементы и присваивает их значения в двумерный массив
        int[,] readPoint()
        {
           
            char[] separators = new char[] { ' ', 'A', 'B', ',', ';', '(', ')' }; //убираем не нужные элементы из строки

            string[] newINPUT = inputLine.Split(separators, StringSplitOptions.RemoveEmptyEntries); //убираем пустые строки


            int pointAX = int.Parse(newINPUT[0]);
            int pointAY = int.Parse(newINPUT[1]);
            int pointAZ = int.Parse(newINPUT[2]);


            int pointBX = int.Parse(newINPUT[3]);
            int pointBY = int.Parse(newINPUT[4]);
            int pointBZ = int.Parse(newINPUT[5]);

            int[,] arrayOut = new int[2, 3]; //создаем новый двумерный массив и присваиваем полученные значения из строки

            arrayOut[0, 0] = pointAX;
            arrayOut[0, 1] = pointAY;
            arrayOut[0, 2] = pointAZ;
            arrayOut[1, 0] = pointBX;
            arrayOut[1, 1] = pointBY;
            arrayOut[1, 2] = pointBZ;

            return arrayOut;
        }

        readPoint();

        //метод подсчета расстояния между координатами в 3D пространстве
        void calculate2D(int[,] arrayPoint)
        {
            float lAB = (float)Math.Sqrt(Math.Pow(arrayPoint[1, 0] - arrayPoint[0, 0], 2) + (Math.Pow(arrayPoint[1, 1] - arrayPoint[0, 1], 2)) + (Math.Pow(arrayPoint[1, 2] - arrayPoint[0, 2], 2)));
            Console.WriteLine(lAB);
        }

        int[,] arrayPoint = readPoint(); //new int[2, 3] { { 3,6, 8 }, { 2, 1, -7 } }; передаем массив полученный из метода readPoint в новый массив и считаем расстояние

        calculate2D(arrayPoint);
    }
}
