// 32. Задать массив из 8 элементов, 
// заполненных нулями и единицами 
// вывести их на экран

void setArrayZerosAndOnes(int elements)
{
    int[] zerosAndOnes = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        if (i%2 == 0) zerosAndOnes[i] = 0;
        else zerosAndOnes[i] = 1;
        Console.Write(zerosAndOnes[i] +" ");
    }
}

setArrayZerosAndOnes(8);