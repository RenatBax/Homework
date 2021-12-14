// 13. Удалить вторую цифру трёхзначного числа

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a - (a%10);
int result = (b/10)%10;
Console.WriteLine($"Вторая цифра трехзначного числа равна: {result}.");
Console.Write(value: $"Давайте удалим вторую цифру? Нажмите любую клавишу...");
Console.ReadKey();
//int[] SecondNanber = new int[b];