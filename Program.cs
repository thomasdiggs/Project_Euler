namespace ProjectEuler
{
    internal class Program
    {
        public static void Problem1()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i%3 == 0) || (i%5 == 0))
                {
                    sum += i;
                }
            }
            Console.WriteLine("Problem 1: " + sum);
        }
        public static void Problem2()
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
        public static void Problem3()
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
        public static void Problem4()
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
        public static void Problem5()
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
                } else
                {
                    i++;
                }
            }
            Console.WriteLine("Problem 5: " + i);
        }
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
        public static void Problem7()
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
        public static void Problem8()
        {
            string thousandDigitNumber = "73167176531330624919225119674426574742355349194934" +
                "96983520312774506326239578318016984801869478851843" +
                "85861560789112949495459501737958331952853208805511" +
                "12540698747158523863050715693290963295227443043557" +
                "66896648950445244523161731856403098711121722383113" +
                "62229893423380308135336276614282806444486645238749" +
                "30358907296290491560440772390713810515859307960866" +
                "70172427121883998797908792274921901699720888093776" +
                "65727333001053367881220235421809751254540594752243" +
                "52584907711670556013604839586446706324415722155397" +
                "53697817977846174064955149290862569321978468622482" +
                "83972241375657056057490261407972968652414535100474" +
                "82166370484403199890008895243450658541227588666881" +
                "16427171479924442928230863465674813919123162824586" +
                "17866458359124566529476545682848912883142607690042" +
                "24219022671055626321111109370544217506941658960408" +
                "07198403850962455444362981230987879927244284909188" +
                "84580156166097919133875499200524063689912560717606" +
                "05886116467109405077541002256983155200055935729725" +
                "71636269561882670428252483600823257530420752963450";
            long largestProduct = 0;
            for (int i = 0; i < thousandDigitNumber.Length - 13; i++)
            {
                long product = 1;
                for (int j = 0; j < 13; j++)
                {
                    product *= int.Parse(thousandDigitNumber[i + j].ToString());
                }
                if (product > largestProduct)
                {
                    largestProduct = product;
                }
            }
            Console.WriteLine("Problem 8: " + largestProduct);
        }

        static void Main(string[] args)
        {
            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Problem5();
            Problem6();
            Problem7();
            Problem8();
        }
    }
}