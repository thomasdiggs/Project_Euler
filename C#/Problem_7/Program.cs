
namespace Problem_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICollection<int> primes = new List<int>();
            int i = 2;
            while (primes.Count < 10_001)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        break;
                    }
                    else if (i == j)
                    {
                        primes.Add(i);
                    }
                }
                i++;
            }
            Console.WriteLine("Problem 7: " + primes.Last());
        }
    }
}
