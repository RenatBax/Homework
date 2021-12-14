// 9. Показать четные числа от 1 до N

void ShowNumbers(int a)
{
    int maxN = a;
    int minN = 1;
    Console.Write("Интервал от введенного числа: ");
    while(minN <= maxN)
    {
        Console.Write(minN +" ");  
        minN++;
    }  
}
void ShowEvenNumbers(int a)
{
    int maxN = a;
    int minN = 1;
    Console.Write("Четные числа с указанном интервале: ");    
    while(minN <= maxN)
    {  
        if(minN%2 == 0)
        {
        Console.Write(minN +" "); 
        }   
        minN++;
    }    
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
ShowNumbers(a);
Console.WriteLine();
ShowEvenNumbers(a);