// 15. Найти третью цифру числа или сообщить, что её нет

void FindThirdNumber(string text)
{
    int length = text.Length;
    int i = 0;
    if (length < 3) Console.WriteLine("Третьего числа нет");
    else while (i < length)
    {
        if (i >= 2)
        {
            Console.WriteLine($"Третье число = {text[2]}");
            break;
        }
        i++;
    }
}

Console.Write("Введите число: ");
string S = Console.ReadLine();
FindThirdNumber(S);