// 43. Написать программу преобразования десятичного числа в двоичное

int conversionBinary(int decim)
{
    int binary = 0;
    int count = decim%2;
    do 
    {
        binary = count/2;
        binary++;
    } while (binary < 0);

    return binary;
}

Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int b = conversionBinary(number);
Console.WriteLine(b);