// 40. В Указанном массиве вещественных чисел 
// найдите разницу между максимальным и минимальным элементом

double[] arrayOfRealNumbers(int n)
{
    double[] array = new double[n];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble();
    }
    return array;
}

void showArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine($" {i} - {array[i]}");
}

string differenceBetweenPosition(double[] array)
{
    string differencePosition = string.Empty;
    int difference = 0;
    int minPosition = 0;
    int maxPosition = 0;
    int size = array.Length;
    int j = 0;
    while (j < size)
    {
        if (array[j] < array[minPosition])
        {
            minPosition = j;
        }
        if (array[j] > array[minPosition] && array[j] > array[maxPosition])
        {
            maxPosition = j;
        }
        j++;
        difference = minPosition - maxPosition;
    }
    return $"Разница в позиции элемента: {minPosition} - {maxPosition} = {difference}";
}

void differenceBetweenNumber(double[] array)
{
    double difference = 0;
    int minPosition = 0;
    double min = array[minPosition];
    double max = 0;
    int maxPosition = 0;
    int size = array.Length;
    int j = 0;
    while (j < size)
    {
        if (array[j] < array[minPosition])
        {
            min = array[j];
            minPosition = j;
        }
        if (array[j] > array[minPosition] && array[j] > array[maxPosition])
        {
            max = array[j];
            maxPosition = j;
        }
        j++;
        difference =  max - min;
    }
    Console.WriteLine($"Разница в позиции числа: {max} - {min} = {difference}");
}

double[] arrayOfReal = arrayOfRealNumbers(10);
Console.WriteLine("Массив вещественных чисел: ");
showArray(arrayOfReal);
string difference = differenceBetweenPosition(arrayOfReal);
Console.WriteLine(difference);
differenceBetweenNumber(arrayOfReal);
