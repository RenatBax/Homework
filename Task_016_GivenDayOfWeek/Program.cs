// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int rnd = new Random().Next(1, 8);
Console.WriteLine("Дано число, обозначающее день недели: " +rnd );

void givenDayOfWeek(int a)
{
    if(a <= 5) Console.WriteLine("Вам не повезло, рабочий день("); 
    if(a == 6) Console.WriteLine("Ура! Выходной день, суббота!");
    if(a == 7) Console.WriteLine("Ура! Выходной день, воскрессенье!");
}
givenDayOfWeek(rnd);