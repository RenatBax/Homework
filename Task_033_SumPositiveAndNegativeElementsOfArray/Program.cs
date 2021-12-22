// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

int[] setArray(int elements)
{
    int[] array = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] +" "); 
    }
}

int sumPositiveElementOfArray(int[] array)
{
    int sumPositive = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPositive = sumPositive + array[i];
    }
    return sumPositive;
}

int sumNegativeElementOfArray(int[] array)
{
    int sumNegative = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative = sumNegative + array[i];
    }
    return sumNegative;
}

int[] arr = setArray(12);
printArray(arr);
Console.WriteLine();
int positive = sumPositiveElementOfArray(arr);
Console.WriteLine($"Сумма положительных элементов массива равна: {positive}.");
int negative = sumNegativeElementOfArray(arr);
Console.WriteLine($"Сумма отрицательных элементов массива равна: {negative}.");