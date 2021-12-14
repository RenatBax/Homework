// 5. Найти максимальное из трех чисел

int maxOfThree(int a, int b, int c)
{
    if (a > b && a > c) return a;
    if (b > a && b > c) return b;
    else return c;
}

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное из трех, равно " +maxOfThree(a, b, c));
