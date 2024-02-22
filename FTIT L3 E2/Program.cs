namespace exercitiu
{
    class Program
    {
        private static bool PrimeOrNot(int num)
        {
            if (num == 1 || num == 0)
                return false;
            else if (num == 2)
                return true;
            else
                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                        return false;
                    else if (num % i != 0)
                        return true;

                }
            return false;
        }
        static void Main()
        {
            Console.WriteLine(PrimeOrNot(38));
        }
    }
}
