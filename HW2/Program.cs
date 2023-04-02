Console.WriteLine("\nПрограмму, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
// Пример
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
string? str = Console.ReadLine();

Console.WriteLine(str[1]);


Console.WriteLine("\nПрограмму, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
// Пример
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите многозвочное число: ");
string? longStr = Console.ReadLine();

if (longStr.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(longStr[2]);
}


