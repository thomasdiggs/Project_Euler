
namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = 600851475143;
            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    n /= i;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine("Problem 3: " + n);
        }
    }
}
