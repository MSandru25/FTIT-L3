/*namespace exercitiu
{
    class Program
    {
        public static int sumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        static void Main()
        {
            Console.WriteLine(sumOfDigits(53));
        }
    }
}*/

//Scrieti o functie care va calcula suma cifrelor unui numar.

static int sumOfDigits(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.WriteLine(sumOfDigits(15));