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
int oddElements(int[] array)
{ 
    int quantity = 0;
    for (int i = 0; i < showArray.Length; i++)
    {
        int a = showArray[i] - showArray[i] % 10;
        int b = showArray[i] - a;
        if (b % 2 != 0) quantity += showArray.Length / 10;
    }
    return quantity;
}
int odd = oddElements(showArray);
Console.WriteLine($"Количество нечетных элементов: {odd}.");
for (int i = 0; i < showArray.Length; i++)
{
    int a = showArray[i] - showArray[i] % 10;
    int b = showArray[i] - a;
    if (b % 2 != 0) Console.Write(showArray[i] + " ");
}

Console.WriteLine();
int eventElements(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < showArray.Length; i++)
    {
        int a = showArray[i] - showArray[i] % 10;
        int b = showArray[i] - a;
        if (b % 2 == 0) quantity += showArray.Length / 10;
    }
    return quantity;
}
int eve = eventElements(showArray);
Console.WriteLine($"Количество четных элементов: {eve}.");
for (int i = 0; i < showArray.Length; i++)
{
    int a = showArray[i] - showArray[i] % 10;
    int b = showArray[i] - a;
    if (b % 2 == 0) Console.Write(showArray[i] + " ");
}

Console.WriteLine();
Console.WriteLine($"Количество нечетных: {odd} / четных: {eve} элемента.");
