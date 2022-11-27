//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.Console.Write("Введите число: ");

Console.Write("Введите номер дня недели: ");

bool isParse = int.TryParse(Console.ReadLine(), out int num);

if (!isParse)
{
    Console.WriteLine("Введено не правильное значение");
}

if (num > 0 && num < 8)
{
    if (num != 6 && num != 7)
        Console.WriteLine("НЕ выходной, марш работать");
    else
        Console.WriteLine("Выходной!!!");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}