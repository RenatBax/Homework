// 12. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int Number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число на отрезке [10, 99] = {Number}.");
string num = Convert.ToString(Number);

int maxNumbers(int text)
{
    int max = 0;
    {
    if ([0] > [1]) max = [0];
    if ([0] < [1]) max = [1];
    }
    return max;
}
int m = maxNumbers(num);
Console.WriteLine($"Наибольшая цифра числа: {m}.");






// int[] CreateArrayNamber(int Nambers)
// {
//     int[] NambersMax = new int[2];
//     for(int index = 0; index < NambersMax.Length; index++)
//     NambersMax[index] = Nambers;
//     return NambersMax;
// }
// void PrintArray(int[] NamberMax)
// {
//     for(int index = 0; index < 1; index++)
//     Console.Write(NamberMax[1] +" ");
// }
// int maxNumbers(int[] array)
// {
    
//     int result = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[0] > array[1]) result = array[0];
//         if (array[0] < array[1]) result = array[1];
//         //else result = 0;
//     }
//     return result;
// } 

// int[] N = CreateArrayNamber(Namber);
// PrintArray(N);
// Console.WriteLine();
// int max = maxNumbers(N);
// Console.WriteLine(max);
// int[] arr = new int[Namber];
// for(int i = 0; i < 1; i++)
// {
//     Console.Write(arr[i] + " ");
//     for(int j = 0; j < 1; j++)
//     {
//     Console.Write(arr[j] + " ");
//     }
// }
//int[] a = new int[arr];
