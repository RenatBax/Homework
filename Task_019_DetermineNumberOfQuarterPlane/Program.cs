// 19. Определить номер четверти плоскости, 
// в которой находится точка с координатами Х и У, 
// причем X ≠ 0 и Y ≠ 0

void whatQuarter (int x, int y)
{
    if ( x > 0 && y > 0 ) 
    {
        Console.WriteLine("Точка с указанными координатами находится в первой четверти.");
    }
    if ( x < 0 && y > 0 ) 
    {
        Console.WriteLine("Точка с указанными координатами находится в второй четверти.");
    }
    if ( x < 0 && y < 0 ) 
    {
        Console.WriteLine("Точка с указанными координатами находится в третьей четверти.");
    }
    if ( x > 0 && y < 0 ) 
    {
        Console.WriteLine("Точка с указанными координатами находится в четвертой четверти.");
    }
    if ( x == 0 || y == 0 ) 
    {
        Console.WriteLine("Введите координаты не равные 0.");
    }
}   

Console.Write("Введите координату Х: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату У: ");
int b = Convert.ToInt32(Console.ReadLine());
whatQuarter(a, b);
