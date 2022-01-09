// 35. Определить, присутствует ли в заданном массиве, некоторое число

void createArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 10);
    }
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(i +":" +array[i] +" ");
    }
}

string specifiedNumber(int[] array, int givenNumber)
{
    string result = String.Empty;
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == givenNumber) 
            {
                result = $"Заданное число присутствует в массиве на позиции {i}.";
                break;
            }
            else 
            {
                result = $"Заданное число отсутствует в массиве.";
            }
        }
        return result;
    }
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[5];
createArray(arr);
string num = specifiedNumber(arr, N);
Console.WriteLine(num);

printArray(arr);

