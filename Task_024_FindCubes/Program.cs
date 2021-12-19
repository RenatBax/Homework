// 24. Найти кубы чисел от 1 до N

void findCubes(double a)
{
    double maxN = a;
    double minN = 1;
    Console.WriteLine($"а | а в кубе"); 
    while(minN <= maxN)
    {
        double degree = 3;
        double cubes = Math.Pow(minN, degree);
        Console.WriteLine($"{minN} |   {cubes}");  
        minN++;
    }  
}

Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
findCubes(a);

