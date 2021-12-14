// 6. Написать программу вычисления значения функции y = f(a)

void functionY(double a)
{
    double result;
    if (a > 0)
    {
        result = (a * 2) - 10;
        Console.Write($"а больше 0, значение функции у=2а-10 = {result}.");
        //return result;
    }
    if (a == 0)
    {
        result = 0;
        Console.Write($"а равно 0, начение функции у={result}.");
        //return 0;
    }
    if (a < 0)
    {
        result = 2 * a - 1;
        Console.Write($"а меньше 0, значение функции у=2|а|-1 = {result}.");
        //return result;
    }
 }

Console.Write("Введите число аргумента а: ");
string S = Console.ReadLine();
double a = Convert.ToDouble(S);
functionY(a);
