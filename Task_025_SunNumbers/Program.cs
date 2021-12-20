// 25. Найти сумму чисел от 1 до А

void ShowNumbers(int a)
{
    int maxA = a;
    int minA = 1;
    Console.Write("Интервал от введенного числа: ");
    while (minA <= maxA)
    {
        Console.Write(minA +" ");  
        minA++;
    }  
}

int sumNumbers(int a)
{
    int maxA = a;
    int minA = 1;
    int sumNumbers = 0;
    while (minA <= maxA)
    {
        int count = minA;
        if (minA <= maxA)
        {  
            sumNumbers = sumNumbers + minA;
            count++;
        }
        minA++;
    }
    return sumNumbers;
}

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
ShowNumbers(a);
Console.WriteLine();
int sum = sumNumbers(a);
Console.WriteLine($"Сумма чисел от 0 до А = {sum}.");