using System.ComponentModel;

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
}



/*Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la tastatura. Scrieti functii care vor returna
• Cel mai mare numar din vector
• Cel mai mic numar din vector
• Numerele divizibile cu 3
• Numerele prime din vector /TODO
*/