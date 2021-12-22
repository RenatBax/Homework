// 31. Задать массив из 8 элементов и вывести их на экран

void setArray(int elements)
{
    int[] array = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        //array[i] = new Random().Next(0, 15);
        Console.Write(array[i] +" ");
    }
}
setArray(8);