// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

void trueOrFalse(bool x, bool y)
{
    if (!(x ^ y) == !x & !y) Console.WriteLine("Утверждение верно");
    else
    {
        Console.WriteLine("Утверждение не верно");
    }
}

bool x = true;
bool y = false;
trueOrFalse(x, y);



 