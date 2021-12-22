// 28. Подсчитать сумму цифр в числе

int sumDigits(string number)
{
    //int length = number.Length;
    int result = 0;
    for (int i = 0; i < number.Length; i++)
    {
        //int j = number[0];
        //if (j < length) 
        result = result + number[i];
        //j++;
    }
    return result;
}

Console.Write("Введите число: ");
string N = Console.ReadLine();
int sum = sumDigits(N);
Console.WriteLine($"Сумма цифр в введенном числе = {sum}.");