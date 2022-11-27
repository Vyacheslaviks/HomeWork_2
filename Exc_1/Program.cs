//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите 3х-значное число: ");

bool isParse = int.TryParse(Console.ReadLine(), out int num);

if (!isParse)
{
    Console.WriteLine("Введено не правильное значение");
}

if (num > 99 && num < 1000)
{
    int second_num = num % 100;
    second_num = second_num / 10;
    Console.WriteLine($"Вторая цифра числа: {second_num}");
}
else
{
    Console.WriteLine("Введено не правильное значение");
}