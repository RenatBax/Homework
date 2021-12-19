// 20. Задать номер четверти, 
//показать диапазоны для возможных координат

void setQuarterNumber(int a)
{
    int max = a;
    int min = -a;    
    if ( a == 1) Console.WriteLine($"Диапазон возможных координат по Х и У от 0 до +{max} и больше.");
    if ( a == 2) Console.WriteLine($"Диапазон возможных координат по Х от 0 до {min} и меньше, по У от 0 до +{max} и больше.");
    if ( a == 3) Console.WriteLine($"Диапазон возможных координат по Х и У от 0 до {min} и меньше.");
    if ( a == 4) Console.WriteLine($"Диапазон возможных координат по Х от 0 до +{max} и больше, по У от 0 до {min} и меньше.");
}
Console.Write("Введите номер четверти (их всего четыре): ");
int numberQuarter = Convert.ToInt32(Console.ReadLine());
setQuarterNumber(numberQuarter);
