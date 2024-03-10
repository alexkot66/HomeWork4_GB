// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];

    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void PrintArrayRecursion(int[] array, int index = 0)
{
    if(index < array.Length)
    {
        PrintArrayRecursion(array, index + 1);
        Console.Write($"{array[index]} ");
    }
   
}

int count = 10;
int minimum = 1;
int maximum = 100;

int[] array = CreateArrayRndInt(count, minimum, maximum);
PrintArray(array);
Console.WriteLine();
PrintArrayRecursion(array);
Console.WriteLine();