int sqrt;
bool breaker;
for (int i = 106732567; i <= 152673836; i++)
{
    sqrt = (int)Math.Sqrt(Math.Sqrt(i));
    breaker = true;
    if (Math.Pow(sqrt, 4) != i)
    {
        continue;
    }
    for (int j = 2; j < sqrt / 2; j++)
    {
        if (sqrt % j == 0)
        {
            breaker = false;
            break;
        }
    }
    if (breaker)
    {
        Console.WriteLine(i + " " + Math.Pow(sqrt, 3));
    }
}