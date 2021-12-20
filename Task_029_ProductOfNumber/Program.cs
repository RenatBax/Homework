// 29. Написать программу вычисления произведения чисел от 1 до N

void ShowNumbers(int N)
{
    int maxN = N;
    int minN = 1;
    Console.Write("Интервал от введенного числа: ");
    while (minN <= maxN)
    {
        Console.Write(minN +" ");  
        minN++;
    }  
}

double productNumbers(double a)
{
    double maxN = a;
    double minN = 1;
    double productNumbers = 1;
    while (minN <= maxN)
    {
        double count = minN;
        if (minN <= maxN)
        {  
            productNumbers = productNumbers * minN;
            Console.WriteLine($"{minN} = {productNumbers}.");
            count++;
        }
        minN++;
    }
    return productNumbers;
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNumbers(N);
Console.WriteLine();
double result = productNumbers(N);
Console.WriteLine($"Произведение чисел от 1 до N = {result}.");

