// 11. Показать вторую цифру трёхзначного числа

void secondNumbers(int a)
{
    int b, c;
    b = a - (a%10);
    c = (b / 10)%10;
    Console.WriteLine($"Вторая цифра числа {c}.");
}
Console.Write("Введите трехзначное число: ");
string S = Console.ReadLine();
int a = Convert.ToInt32(S);
secondNumbers(a);
