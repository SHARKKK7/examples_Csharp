internal partial class Program
{
    private static void Main(string[] args)
    {
        //A (3,6); B (2,1)
        //A (7,-5); B (1,-1)

        int[,] readPoint()
        {
            // Мой вариант решения
            string? inputLine = Console.ReadLine();


            string pointAXLine = inputLine.Substring(0, inputLine.IndexOf(","));
            pointAXLine = pointAXLine.Substring(pointAXLine.IndexOf("(") + 1);

            string pointAYLine = inputLine.Substring(inputLine.IndexOf("A"), inputLine.IndexOf(")"));
            pointAYLine = pointAYLine.Substring(pointAYLine.IndexOf(",") + 1);

            string pointBXLine = inputLine.Substring(inputLine.IndexOf("B"), inputLine.IndexOf(","));
            pointBXLine = pointBXLine.Substring(pointBXLine.IndexOf("(") + 1);

            string pointBYLine = inputLine.Substring(inputLine.IndexOf("B"), inputLine.IndexOf(")"));
            pointBYLine = pointBYLine.Substring(pointBYLine.IndexOf(",") + 1);

            int pointAX = int.Parse(pointAXLine);
            int pointAY = int.Parse(pointAYLine);

            int pointBX = int.Parse(pointBXLine);
            int pointBY = int.Parse(pointBYLine);

            int[,] arrayOut = new int[2, 2];
            arrayOut[0, 0] = pointAX;
            arrayOut[1, 0] = pointAY;
            arrayOut[0, 1] = pointBX;
            arrayOut[1, 1] = pointBY;

            return arrayOut;
        }

        void calculate2D(int[,] arrayPoint)
        {
            float lAB = (float)Math.Sqrt(Math.Pow(arrayPoint[0, 0] - arrayPoint[0, 1], 2) + (Math.Pow(arrayPoint[1, 0] - arrayPoint[1, 1], 2)));
            Console.WriteLine(lAB);

        }

        int[,] arrayPoint = readPoint();
        calculate2D(arrayPoint);

        //Console.WriteLine(pointAY + " " + pointBY);
        //Console.WriteLine(pointAX + " " + pointBX);
        //distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    }
}