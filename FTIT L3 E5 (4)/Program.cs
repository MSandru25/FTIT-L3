/*Ex 4. Scrieti un program care va inversa elementele unui vector
 Lungimea vectorului va fi citita de la tastatura
 Inversarea elementelor va fi facuta in functia Main (fara o functie dedicate)
 Afisarea vectorului se va face printr-o functie de afisare dedicata*/

Console.Write("Cate elemente are vectorul ? ");
int n = int.Parse(Console.ReadLine());
int[] array = readArray(n);
Array.Reverse(array);
Console.WriteLine("Vectorul inversat este: ");
showArray(array);
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

static void showArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}