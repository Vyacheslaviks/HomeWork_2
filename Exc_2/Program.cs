//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");

bool isParse = int.TryParse(Console.ReadLine(), out int num);

if (!isParse)
{
    Console.WriteLine("Введено не правильное значение");
}

if (num > 99)
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    num = num % 10;
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Число меньше трезначного");
}