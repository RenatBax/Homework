// 2. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите первое число: ");
string S = Console.ReadLine();
double a = Convert.ToDouble(S);
Console.WriteLine("Введите второе число: ");
string s = Console.ReadLine();
double b = Convert.ToDouble(s);
double FirstSquareSecond(double a, double b)
{
    if (b / a == a)
    {
        Console.WriteLine("Первое число является квадратом второго. ");
    }
    else
    {
        Console.WriteLine("Первое число не является квадратом второго. ");
        
    }
    return b;
}
FirstSquareSecond(a, b);