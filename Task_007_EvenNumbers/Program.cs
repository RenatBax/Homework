// 7. Выяснить является ли число чётным

void evenNumbers(double a)
{
    if (a%2 == 0) Console.WriteLine($"Число {a} четное.");
    else Console.WriteLine($"Число {a} нечетное.");
}
Console.Write("Введите число, чтобы узнать четное оно или нет: ");
string S = Console.ReadLine();
double a = Convert.ToDouble(S);
evenNumbers(a);