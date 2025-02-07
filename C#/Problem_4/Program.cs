
namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largestPalindrome = 0;
            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 90; j--)
                {
                    int product = i * j;
                    string productString = product.ToString();
                    char[] productArray = productString.ToCharArray();
                    Array.Reverse(productArray);
                    string reverseProductString = new string(productArray);
                    if (productString == reverseProductString)
                    {
                        if (product > largestPalindrome)
                        {
                            largestPalindrome = product;
                        }
                    }
                }
            }
            Console.WriteLine("Problem 4: " + largestPalindrome);
        }
    }
}
