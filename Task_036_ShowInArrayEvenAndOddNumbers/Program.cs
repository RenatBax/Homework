// 36. Задать массив, 
// заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

void createArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);

}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int[] showArray = new int[10];
createArray(showArray);
printArray(showArray);
Console.WriteLine();

Console.Write("Количество четных элементов: ");
for (int i = 0; i < showArray.Length; i++)
{
    int a = showArray[i] - showArray[i] % 10;
    int b = showArray[i] - a;
    if (b % 2 == 0)
    {
        Console.Write(showArray[i]+" ");
    }
}
Console.WriteLine();
Console.Write("Количество нечетных элементов: ");
for (int i = 0; i < showArray.Length; i++)
{
    int a = showArray[i] - showArray[i] % 10;
    int b = showArray[i] - a;
    if (b % 2 != 0)
    {
        Console.Write(showArray[i] +" ");
    }
}

// Доработка кода - вывод с помощью метода

// int[] showEvenAndOddNumbers(int[] arr)
// {
//     int[] resalt = new int[10];
    
//     for (int i = 0; i < arr.Length; i++)
//     {
//         int a = arr[i] - arr[i]%10;
//         int b = arr[i] - a; 
//         if (b%2 == 0) resalt[i] = arr[i];
//     }
//     return resalt;
// }

// int[] show = showEvenAndOddNumbers(showArray);
// printArray(show);

