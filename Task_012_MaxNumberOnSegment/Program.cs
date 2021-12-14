// 12. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int Namber = new Random().Next(10, 100);
Console.WriteLine($"Случайное число на отрезке [10, 99] = {Namber}.");
Console.WriteLine();
// int[] CreateArrayNamber(int Nambers)
// {
//     int[] NambersMax = new int[2];
//     for(int index = 0; index < 1; index++)
//     NambersMax[index] = Nambers;
//     return NambersMax;
// }
// void PrintArray(int[] NamberMax)
// {
//     for(int index = 0; index < 1; index++)
//     Console.Write(NamberMax[1] +" ");
// }
// int[] N = CreateArrayNamber(Nambers);
// PrintArray(N);

int[] arr = new int[Namber];
for(int i = 0; i < 1; i++)
{
    Console.Write(arr[i] + " ");
    for(int j = 0; j < 1; j++)
    {
    Console.Write(arr[j] + " ");
    }
}
//int[] a = new int[arr];
