// 23. Показать таблицу квадратов чисел от 1 до N

void tableOfSquares(int a)
{
    int maxN = a;
    int minN = 1;
    Console.WriteLine($"а | а х а"); 
    while(minN <= maxN)
    {
        int square = minN * minN;
        Console.WriteLine($"{minN} |   {square}");  
        minN++;
    }  
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
tableOfSquares(a);
