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

// Второй способ
int calculateDigits(long number)
{
    int calculate = 0;
    while (number != 0)
    {
        calculate++;
        number = number/10;
    }
    return calculate;
}
long digit = Convert.ToInt64(N);
Console.WriteLine("Второй способ: " +calculateDigits(digit));