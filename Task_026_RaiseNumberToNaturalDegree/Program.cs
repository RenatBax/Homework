// 26. Возведите число А в натуральную степень B 
//используя цикл

double raiseNamberToDegree(double number, double numberDegree)
{
    double finiteNumber = 1;
    for (double count = 0; count < numberDegree; count++)
    {
        finiteNumber = finiteNumber * number;
    }
    return finiteNumber;
}

Console.Write("Введите число А: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите натуральную степень В, в которую хотите возвести число А: ");
double b = Convert.ToDouble(Console.ReadLine());

double result = raiseNamberToDegree(a, b);
Console.WriteLine(result);