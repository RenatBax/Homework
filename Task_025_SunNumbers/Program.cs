// 25. Найти сумму чисел от 1 до А

void sumNambers(int a)
{
    int maxN = a;
    int minN = 1;
    //Console.WriteLine($"а | а х а"); 
    while(minN <= maxN)
    {
        int sum = minN + minN;
        Console.WriteLine(sum);  
        minN++;
    }  
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
sumNambers(a);