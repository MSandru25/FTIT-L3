/*namespace exercitiu
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

*/

static bool IsSquare(int x)
{
    var y = Math.Sqrt(x);
    if (y % 1 == 0)
    {
        return true;
    }

    return false;
}

Console.WriteLine(IsSquare(3));

//Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatul (E2)
