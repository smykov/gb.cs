Console.WriteLine("\nПрограмма, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
// Пример
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
string? str = Console.ReadLine();

Console.WriteLine(str[1]);


Console.WriteLine("\nПрограмма, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
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


Console.WriteLine("\nПрограмма, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
// Пример
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");

switch (Console.ReadLine())
{
    case "1":
    case "2":
    case "3":
    case "4":
    case "5":
        Console.WriteLine("нет");
        break;
    case "6":
    case "7":
        Console.WriteLine("да");
        break;
    default:
        Console.WriteLine("Ошибка ввода!");
        break;
}