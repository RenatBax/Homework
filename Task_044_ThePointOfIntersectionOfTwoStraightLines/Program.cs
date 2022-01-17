// 44. Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

void pointOfIntersection(int b1, int k1, int b2, int k2)
{
    int y = (k2 / (k2 * k1) - (k2 * b1)) + b2;
    int x = y / k1 - b1;
    Console.WriteLine($"Точка пересечения прямых {x}, {y}.");
}

Console.WriteLine("Даны две прямые, заданные уравнением y = k1 * x + b1, y = k2 * x + b2.");
Console.Write("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

pointOfIntersection(b1, k1, b2, k2);
