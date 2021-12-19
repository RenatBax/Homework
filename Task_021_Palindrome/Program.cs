// 21. Программа проверяет пятизначное число на палиндромом.

void palindrome(string text)
{
    if (text[0] == text[4] && text[1] == text[3]) Console.WriteLine("Введенное число являетcя палиндромом.");
    else Console.WriteLine("Введенное число не палиндром.");
}

Console.Write("Введите пятизначное число: ");
string S = Console.ReadLine();
palindrome(S);

