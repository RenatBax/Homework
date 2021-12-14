// 4. По заданному номеру дня недели вывести его название

Console.Write("Введите число дня недели: ");
string S = Console.ReadLine();
int a = Convert.ToInt32(S);
void ShowNameDay(int a)
{
    if(a == 1) Console.WriteLine("Понедельник"); 
    if(a == 2) Console.WriteLine("Вторник"); 
    if(a == 3) Console.WriteLine("Среда"); 
    if(a == 4) Console.WriteLine("Четверг"); 
    if(a == 5) Console.WriteLine("Пятница");
    if(a == 6) Console.WriteLine("Суббота");
    if(a == 7) Console.WriteLine("Воскрессенье");
    if(a < 1 || a > 7)
    {
        Console.WriteLine("Такого дня недели не существует");
    }
        
}
ShowNameDay(a);