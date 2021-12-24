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

// int[] firstPartOfArray(int[] array)
// {
//     int[] result = new int[6];
//     int a = array.Length;
//     int b = array.Length / 2;
//     int c = a - b;
//     for(int i = 0; i < b; i++)
//     {
//         result[i] = array[i];
//     }
//     return result;
// }

// int[] secondPartOfArray(int[] array)
// {
//     int[] result = new int[12];
//     int a = array.Length;
//     int b = array.Length / 2;
//     int c = a - b;
//     for(int i = a - 1; i >= c; i--)
//     {
//         result[i] = array[i];
//     }
//     return result;
// }

int[] mainArray = fullArray(12);
Console.Write("Одномерный массив из 12 элементов: ");
printArray(mainArray);

Console.WriteLine();
// int[] fP = firstPartOfArray(mainArray);
// printArray(fP);

// Console.WriteLine();
// int[] sP = secondPartOfArray(mainArray);
// printArray(sP);
// int productNumber = productOfPairsOfArray(first);
// Console.WriteLine($"Произведение чисел, стоящих на крайних позициях: {productNumber}.");

int a = mainArray.Length;
int b = mainArray.Length / 2;
int c = a - b;

for(int i = 0; i < b; i++)
{
    Console.Write(mainArray[i] + " ");
}
Console.WriteLine();
for (int j = a - 1; j >= c; j--) //(int j = c; j < a; j++)
{
    Console.Write(mainArray[j] +" ");
}
    



