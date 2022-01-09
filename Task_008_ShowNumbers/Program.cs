// 8. Показать числа от -N до N

void ShowNumbers(int a)
{
    int maxN = a;
    int minN = -a;
    Console.Write("Интервал от введенного числа: ");
    while(minN <= maxN)
    {
        Console.Write(minN +" ");  
        minN++;
    }
    while(maxN <= minN)
    {
        Console.Write(maxN +" ");
        maxN++;
    }
}

void ShowNumbers2(int a)
{
    for (int i = -a; i <= a; i++)
    Console.Write(i +" ");
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
ShowNumbers(a);
Console.Write("\nИнтервал от введенного числа: ");
ShowNumbers2(a);
