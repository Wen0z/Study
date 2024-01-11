double wayLenght, touristsSpeed, time, maxDistance, curentDistance = 0;
int sunriseTime, sunsetTime, stopsCount, days = 0;

Console.WriteLine("Введите длину пути");
wayLenght = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите скорость туристов км/ч");
touristsSpeed = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите количество остановок");
stopsCount = Convert.ToInt32(Console.ReadLine());

double[] dictances = new double[stopsCount + 2];
dictances[0] = 0;
dictances[stopsCount + 1] = wayLenght;

List<int> stops = new List<int>();

Console.WriteLine("Введите время захода (часы и минуты через пробел)");
String[] input_sunset = Console.ReadLine().Split(" ");
sunsetTime = Convert.ToInt32(input_sunset[0]) * 60 + Convert.ToInt32(input_sunset[1]);

Console.WriteLine("Введите время восхода (часы и минуты через пробел)");
String[] inputSunrise = Console.ReadLine().Split(" ");
sunriseTime = Convert.ToInt32(inputSunrise[0]) * 60 + Convert.ToInt32(inputSunrise[1]);


time = (sunsetTime - sunriseTime) / 60;

maxDistance = touristsSpeed * time;

curentDistance += maxDistance;

Console.WriteLine("Введите расстояния от начала пути до каждой остановки");

for (int i = 1; i < stopsCount + 1; i++)
{
    dictances[i] = Convert.ToDouble(Console.ReadLine());
}

for (int i = 1; i < stopsCount + 2; i++)
{
    if (dictances[i] > curentDistance)
    {
        days++;
        curentDistance = dictances[i - 1];
        curentDistance += maxDistance;
        stops.Add(i - 1);
    }
}

Console.WriteLine("Затраченные дни " + days);

for (int i = 0; i < stopsCount; i++)
{
    Console.WriteLine("Остановка " + stops[i]);
}