namespace ProjectEuler
{
    internal class Program
    {
        public static void Problem6()
        {
            int sumOfSquares = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += (i * i);
            }
            int squareOfSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                squareOfSum += i;
            }
            squareOfSum *= squareOfSum;
            int difference = squareOfSum - sumOfSquares;
            Console.WriteLine("Problem 6: " + difference);
        }

        static void Main(string[] args)
        {
            Problem6();
        }

    }
}
