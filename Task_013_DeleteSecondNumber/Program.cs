// 13. Удалить вторую цифру трёхзначного числа

void FindThirdNumber(string text)
{
    Console.WriteLine($"Вторая цифра {text[0]}{ text[2]}");
}

Console.Write("Введите трехзначное число: ");
string S = Console.ReadLine();
FindThirdNumber(S);


// Второй вариант решения - не доделанный

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = a - (a%10);
// int result = (b/10)%10;
// Console.WriteLine($"Вторая цифра трехзначного числа равна: {result}.");
// Console.Write(value: $"Давайте удалим вторую цифру? Нажмите любую клавишу...");
// Console.ReadKey();
//int[] SecondNanber = new int[b];