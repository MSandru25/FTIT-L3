﻿/*namespace exercitiu
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
*/

static bool PrimeOrNot(int num)
{
    if (num == 1 || num == 0)
    { return false; }
    else if (num == 2)
    { return true; }
    else
    {
        for (int i = 2; i <= num - 1; i++)
        {
            if (num % i == 0)
            { return false; }

        }
    }
    return true;
}

Console.WriteLine(PrimeOrNot(3));

//(Cred ca) acesta era E2 la inceput (am facut inainte putin)
