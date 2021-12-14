// 15. Дано число. Проверить кратно ли оно 7 и 23

// Console.WriteLine("Введите число: "); //Проверка, все работает
// int Namber = Convert.ToInt32(Console.ReadLine());

for(int Namber = 1; Namber < 1000; Namber++) // Доработка с семинара, подсказал Андрей Заярный
{

// int Namber = new Random().Next(-1000, 1000);
// Console.WriteLine($" Дано число: {Namber}.");
//int count; // Доделать автомат введение, до нахождения
if(Namber % 7 == 0 && Namber % 23 == 0)  //if
{
    
    Console.WriteLine($"Случайное число {Namber}, кратно 7 и 23");
    break; // Остановка если нашли
}
    else
    Console.WriteLine($"Случайное число {Namber} нам не подходит");
}