// 37. В одномерном массиве из 123 чисел 
// найти количество элементов из отрезка [10,99]

int[] createArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 124);
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int[] elementsOfSegment(int[] array)
{
    int[] result = new int[99];
    //for (int i = array.Length - 1; i >= 0; i--)
    for (int i = 0; i < array.Length; i++)
    {
        if (i <= 8 || i >= 99)
            continue;
        result[i] = array[i];
    }
    return result;
}

int[] array123 = createArray(123);
Console.Write($"Количество элементов 123: ");
printArray(array123);
Console.WriteLine();
Console.WriteLine();
int[] elements = elementsOfSegment(array123);

Console.Write($"Количество элементов на отрезке [10,99]: ");
for (int i = 0; i < elements.Length; i++)
{
    if (i >= 9) Console.Write(elements[i] + " ");
}

