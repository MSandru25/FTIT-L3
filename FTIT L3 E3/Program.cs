namespace exercitiu
{
    class Program
    {
        static bool IsSquare(int x)
        {
            var y = Math.Sqrt(x);
            if (y % 1 == 0)
            {
                return true;
            }

            return false;
        }

        static void Main()
        {
            Console.WriteLine(IsSquare(3));
        }
    }
}
