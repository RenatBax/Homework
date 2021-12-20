// 30. Показать кубы чисел, заканчивающихся на четную цифру

void showCubes(double a)
{
    for (double minN = 1; minN <= a; minN++)
    {
        double showCubes = Math.Pow(minN, 3);
        Console.WriteLine($" {minN} | {showCubes}");
    }
}

void eventCubes(double a)
{
    Console.Write("Кубы, заканчивающие на четную цифру: ");
    for (double minN = 1; minN <= a; minN++)
    {
        double cubes = Math.Pow(minN, 3);
        if (cubes%2 == 0) Console.Write(cubes +" ");
    }
}

Console.Write("Введите число A: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" A | A в кубе");
showCubes(a);

eventCubes(a);

