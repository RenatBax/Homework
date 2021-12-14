// 3. Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите первое число: ");
string S = Console.ReadLine();
double a = Convert.ToDouble(S);
Console.WriteLine("Введите второе число: ");
string s = Console.ReadLine();
double b = Convert.ToDouble(s);

void ShowMaxAndMin(double a, double b)
{
    if(a > b) Console.WriteLine($"Первое число {a} больше {b}.");
    else
    {
        Console.WriteLine($"Второе число {b} больше {a}.");
    }
}
ShowMaxAndMin(a, b);