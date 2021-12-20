// 27. Определить количество цифр в числе

double determineNumberOfDigits(string number)
{
    double length = number.Length;
    double result = length;
    return result;
}

Console.Write("Введите число: ");
string N = Console.ReadLine();
double digits = determineNumberOfDigits(N);
Console.WriteLine($"Количество цифр в введенном числе: {digits}.");