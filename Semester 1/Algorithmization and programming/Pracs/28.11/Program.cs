using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string input = Console.ReadLine();

        int nechet = 0;

        input = input.ToLower();

        int length = input.Length;
        bool palindrome = true;
        int inx, n, sum, max = 0;
        for (int i = 0; i < length; i++)
        {
            if ((1 + i < length) && (input[i] == input[i + 1]))
            {
                inx = i; n = 1; sum = 2;
                while ((inx - n >= 0) && (inx + 1 + n < length) && (input[inx - n] == input[inx + 1 + n]))
                {
                    n += 1; sum += 2;
                }
                if (sum > max) max = sum;
            }
            else
            {
                inx = i; n = 1; sum = 1;
                while ((inx - n >= 0) && (inx + n < length) && (input[inx - n] == input[inx + n]))
                {
                    n += 1; sum += 2;
                }
                if (sum > max) max = sum;
            }

        }
        Console.WriteLine("Максимальная длина:", max);
    }
}