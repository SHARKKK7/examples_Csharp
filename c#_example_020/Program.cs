internal class Program
{
    private static void Main(string[] args)
    {
    
        //метод считывает точки и возвращает массив
        int[,] readPoint()
        {
            string inputLine = Console.ReadLine();

            // x=34;y=-30

            string coordXLine = inputLine.Substring(0, inputLine.IndexOf(";")); //метод индексов от 0-;, где 0 начало строки;
            coordXLine = coordXLine.Substring(coordXLine.IndexOf("=") + 1);

            string coordYLine = inputLine.Substring(inputLine.IndexOf(";") + 1); //метод индексов от 0-;
            coordYLine = coordYLine.Substring(coordYLine.IndexOf("=") + 1);


            //Console.WriteLine(coordX+" "+coordY);

            int coordX = int.Parse(coordXLine);
            int coordY = int.Parse(coordYLine);

            int[,] arrayOut = new int[1, 2];
            arrayOut[0, 0] = coordX;
            arrayOut[0, 1] = coordY;

            return arrayOut;
        }

        //Console.WriteLine(coordX+" "+coordY);

        //метод печатает номер четверти
        void printQuter(int[,] arrayPoint)
        {
            if (arrayPoint[0, 0] > 0 && arrayPoint[0, 1] > 0)
                Console.WriteLine("1-я четверть");

            if (arrayPoint[0, 0] < 0 && arrayPoint[0, 1] > 0)
                Console.WriteLine("2-я четверть");

            if (arrayPoint[0, 0] < 0 && arrayPoint[0, 1] < 0)
                Console.WriteLine("3-я четверть");

            if (arrayPoint[0, 0] > 0 && arrayPoint[0, 1] < 0)
                Console.WriteLine("4-я четверть");

        }

        int[,] arrayPoint = readPoint();
        printQuter(arrayPoint);

        //printQuter(readPoint());
        //Console.WriteLine("Hello, World!");
    }
}
