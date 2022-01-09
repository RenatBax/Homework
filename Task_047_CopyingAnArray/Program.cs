// 47. Написать программу копирования массива

int[] arr = {1, 2, 3, 4, 5, 6};

void printArray(int[] array, int copy)
{
    int t = 0;
    while (t != copy)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] +" ");
        }
        Console.WriteLine();
        t++;
    }
}

printArray(arr, 7);