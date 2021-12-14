// 14. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите число: ");
int Namber = Convert.ToInt32(Console.ReadLine());

int Nambers = new Random().Next(-1000, 1000);
Console.WriteLine($"Случайное заданное число = {Nambers}.");
decimal result = (decimal)Nambers /  (decimal)Namber;
Console.WriteLine($"В результате деления получилочь число: {result}.");
Console.ReadKey();
if(result % 2 == 0)
{
    Console.WriteLine($"Введенное число кратно заданному и равно: {result}.");
}
else

{
    decimal Remains = result - (result - (result % 2));
    Console.WriteLine($"Число некратное, остаток равен: {Remains}.");
}
