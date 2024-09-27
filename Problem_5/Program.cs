
namespace Problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool found = false;
            int i = 1;
            while (!found)
            {
                bool divisible = true;
                for (int j = 1; j <= 20; j++)
                {
                    if (i % j != 0 && divisible)
                    {
                        divisible = false;
                        break;
                    }
                }
                if (divisible)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine("Problem 5: " + i);
        }
    }
}
