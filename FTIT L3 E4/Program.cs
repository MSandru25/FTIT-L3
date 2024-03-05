/*using System.ComponentModel;

namespace exercitiu
{
    class Program
    {
        static void Main()
        {
            int[] lista = { 9, 6, 8, 3 };
            Console.WriteLine(maxNum(lista));
            Console.WriteLine(minNum(lista));
            divThree(lista);
            isprime(lista);
        }
        public static int maxNum(int[] nums)
        {
            int hiNum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > hiNum)
                    hiNum = nums[i];
            }
            return hiNum;
        }
        public static int minNum(int[] nums)
        {
            int loNum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < loNum)
                    loNum = nums[i];
            }
            return loNum;

        }
        public static void divThree(int[] nums)
        { 
            List<int> newList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 3 == 0)
                {
                    newList.Add(nums[i]);
                }

            }
            foreach (int i in newList)
            {
                Console.WriteLine(i);
            }
            return;
        }       
        public static void isprime(int[] nums)
        {
            List<int> newerList = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 2)
                {
                    newerList.Add(nums[i]);
                }
                else
                {
                for (int j = 1; j <= nums[i]; j++ )
                    if (nums[i] % j == 0)
                        { break; }
                    else
                        {
                            newerList.Add(nums[i]);
                        }
                }
            }
            foreach(int i in newerList)
            { Console.WriteLine(i); }
        }
    }
}*/


using System.Runtime.CompilerServices;

Console.Write("Cate elemente are vectorul ? ");
int n = int.Parse(Console.ReadLine());
int[] array = readArray(n);
Console.WriteLine($"Cel mai mare numar din vector este: {MaxNum(array)}");
Console.WriteLine($"Cel mai mic numar din vector este: {MinNum(array)}");
//DivThree(array);
//IsSquare(array);
//ListPrime(array);
Console.WriteLine("Numerele divizibile cu 3 din vector sunt: ");
foreach (int i in array)
{
    if (DivThree(i))
    { Console.WriteLine(i); }
}
Console.WriteLine("Patratele perfecte din vector sunt: ");
foreach (int i in array)
{
    if (IsSquare(i))
    { Console.WriteLine(i); }
}

Console.WriteLine("Numerele prime din vector sunt: ");
foreach(int i in array)
{
    if (IsPrime(i))
    { Console.WriteLine(i); }
}




static int[] readArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Elementul {i + 1}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

static int MaxNum(int[] arr)
{
    int hiNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > hiNum)
            hiNum = arr[i];
    }
    return hiNum;
}

static int MinNum(int[] arr)
{
    int loNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < loNum)
            loNum = arr[i];
    }
    return loNum;

}

/*static void DivThree(int[] arr)
{
    List<int> divThreeList = new List<int>();

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 3 == 0)
        {
            divThreeList.Add(arr[i]);
        }

    }
    Console.WriteLine("Numerele divizibile cu 3 din vector sunt: ");
    foreach (int i in divThreeList)
    {
        Console.WriteLine(i);
    }
    return;
}*/

/*static void IsSquare(int[] arr)
{
    List<int> sqList = new List<int>();

    for (int i = 0; i < arr.Length; i++)
    {
        if (Math.Sqrt(arr[i]) % 1 == 0)
        {
            sqList.Add(arr[i]);
        }

    }
    Console.WriteLine("Patratele perfecte din vector sunt: ");
    foreach (int i in sqList)
    {
        Console.WriteLine(i);
    }
    return;
}*/

static bool IsPrime(int num)
{
    int i;
    for (i = 2; i <= num - 1; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    if (i == num)
    {
        return true;
    }
    return false;
}

/*static void ListPrime(int[] arr)
{
    List<int> primeList = new List<int>();
    for (int i = 0 ; i < arr.Length ; i++)
    {
        if (IsPrime(arr[i]))
        { primeList.Add(arr[i]); }
    }
    Console.WriteLine("Numerele prime din vector sunt: ");
    foreach (int i in primeList)
    {
        Console.WriteLine(i);
    }
}*/

static bool DivThree(int num)
{
    if (num % 3 == 0)
    { return true; }
    return false;
}

static bool IsSquare(int num)
{
    if (Math.Sqrt(num) % 1 == 0)
    { return true; }
    return false;
} 

/*Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la tastatura. Scrieti functii care vor returna
• Cel mai mare numar din vector
• Cel mai mic numar din vector
• Numerele divizibile cu 3
• Numerele prime din vector
• Numerele patrate perfecte din vector
(Asa era cand m-am apucat de exercitiu)
*/