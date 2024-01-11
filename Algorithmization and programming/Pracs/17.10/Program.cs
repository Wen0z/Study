int n, k, pos, curPosition;
List<int> mouse = new List<int>();
List<int> whiteMouse = new List<int>();

Console.WriteLine("Введите количество мышей");
n = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine("Введите позицию белой мыши");
pos = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine("Введите какую по счету мышь съедать");
k = Convert.ToInt32(Console.ReadLine()) - 1;

for (int i = 0; i < n; i++)
{

    for (int j = 0; j <= n; i++)
    {
        if (i == pos)
        {
            whiteMouse.Add(1);
        }
        else
        {
            whiteMouse.Add(0);
        }
    }

    curPosition = i + k;
    if (curPosition >= whiteMouse.Count)
    {
        while (curPosition >= whiteMouse.Count)
        {
            curPosition -= whiteMouse.Count;
        }
    }
    whiteMouse.RemoveAt(curPosition);

    while (whiteMouse.Count > 1)
    {
        curPosition += (k + 1 - (mouse.Count - whiteMouse.Count));

        if (curPosition >= whiteMouse.Count)
        {
            while (curPosition >= whiteMouse.Count)
            {
                curPosition -= whiteMouse.Count;
            }
        }

        whiteMouse.RemoveAt(curPosition);
    }

    if (whiteMouse[0] == 1)
    {
        Console.WriteLine(i);
        break;
    }
}