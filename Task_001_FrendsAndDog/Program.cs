// Задача с друзьями и собакой.

double distance  = 10000;
double firstFrendSpeed = 1, secondFrendSpeed = 2, dogSpeed = 5;
double frend = 2, count = 0;
double time;

while (distance > 5)
{
    if (frend == 1)
    {
        time = distance / (firstFrendSpeed + dogSpeed);
        frend = 2;
    }
    else//if (frend != 1)
    {
        time = distance / (secondFrendSpeed + dogSpeed);
        frend = 1;
    }
    distance = distance - ((firstFrendSpeed + secondFrendSpeed) * time);
    count++;
}

Console.Write($"Cобака пробежит {count} раз.");


