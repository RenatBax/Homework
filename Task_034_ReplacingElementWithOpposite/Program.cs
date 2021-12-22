// 34. Написать программу замену элементов массива на противоположные

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
        Console.Write(array[i] +"  "); 
    }
}

int[] replaceArray(int[] arr)
{
    int[] opposite = new int[10];
    for (int i = 0; i < arr.Length; i++)
    {
        // if (arr[i] < 0) opposite[i] = arr[-i];
        // if (arr[i] > 0) opposite[-i] = arr[i];
        opposite[i] = -1 * arr[i];
    }
    return opposite;
}

int[] arr = setArray(10);
printArray(arr);
Console.WriteLine();
int[] oppositeElements = replaceArray(arr);
printArray(oppositeElements);
