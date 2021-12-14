// 1. Вывести квадрат числа


Console.WriteLine("Введите число, которое хотите возвести в квадрат: ");
string S = Console.ReadLine();
double a = Convert.ToDouble(S);
double SquareOfNamder(double a)
{
    double result = a * a;
    return result;
}

Console.WriteLine("Квадрат введеного числа, равен: " +SquareOfNamder(a));

