// 35. Определить, присутствует ли в заданном массиве, некоторое число

void createArray(int[] givenArray)
{
    int length = givenArray.Length;
    for (int i = 0; i < length; i++)
    {
        givenArray[i] = new Random().Next(0, 10);
    }
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] +" ");
    }
}

string specifiedNumber(int[] givenArray, int givenNumber)
{
    string result = String.Empty;
    {
        for (int i = 0; i < givenArray.Length; i++)
        {
            if (givenArray[i] == givenNumber) 
            result = $"Заданное число присутствует в массиве.";
            else result = $"Заданное число отсутствует в массиве.";
        }
        return result;
    }
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[5];
createArray(arr);
string num = specifiedNumber(arr, N);
Console.WriteLine(num);

printArray(arr);

