// По двум заданным числам проверять является ли одно квадратом другого

void FirstSquareSecond (double a, double b)
{
    if (b / a == a) Console.WriteLine("Первое число является квадратом второго. ");
    
    if (a / b == b) Console.WriteLine("Второе число является квадратом первого. ");
        
    if ((b / a == a) == (a / b == b)) Console.WriteLine("Введенные цифры не являются квадратом друг друга. ");
}

Console.Write("Введите первое число: ");
string S = Console.ReadLine();
double a = Convert.ToDouble(S);
Console.Write("Введите второе число: ");
string s = Console.ReadLine();
double b = Convert.ToDouble(s);
FirstSquareSecond(a, b);