// 10. Показать последнюю цифру трёхзначного числа

void lastNumbers(int a)
{
    int b;
    b = a - (a - a%10);
    Console.WriteLine($"Последняя цифра числа {b}.");
}
Console.Write("Введите трехзначное число: ");
string S = Console.ReadLine();
int a = Convert.ToInt32(S);
lastNumbers(a);