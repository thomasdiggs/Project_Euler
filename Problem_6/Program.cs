
namespace Problem_6
{
    internal class Program
    {
        static void Main(string[] args)
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
    }
}
