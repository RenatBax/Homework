// 39. Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] fullArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 10);
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] +" ");
}

int[] productOfPartOfArray(int[] array)
{
    int a = array.Length;
    int b = array.Length / 2;
    int[] result = new int[b];
    int i = 0;
    int j = a - 1;
    while (i < b)
    {
        result[i] = array[i] * array[j];
        i++;
        j--;
    }
    return result;
}

int[] mainArray = fullArray(12);
Console.Write("Одномерный массив из 12 элементов: ");
printArray(mainArray);

Console.Write("\nПроизведение пар чисел: ");
int[] productOfPart = productOfPartOfArray(mainArray);
printArray(productOfPart);
