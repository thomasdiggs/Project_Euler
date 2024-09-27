
namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int a = 1;
            int b = 2;
            while (b < 4000000)
            {
                if (b % 2 == 0)
                {
                    sum += b;
                }
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine("Problem 2: " + sum);
        }
    }
}
