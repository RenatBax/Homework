// 38. Найти сумму чисел одномерного массива 
// стоящих на нечетной позиции

int[] fullArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(- 10, 10);
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] +" ");
}

int sumOddIndexOfArray(int[] array)
{
    int sumPosition = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0) sumPosition = sumPosition + array[i];
    }
    return sumPosition;
}

int[] first = fullArray(10);
Console.WriteLine("                                    0 1 2 3 4 5 6 7 8 9");
Console.Write("Одномерный массив из 10 элементов: ");
printArray(first);
Console.WriteLine();
int sumNumber = sumOddIndexOfArray(first);
Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции: {sumNumber}.");