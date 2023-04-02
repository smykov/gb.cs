Console.WriteLine("\nПрограмму, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
// Пример
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
string? str = Console.ReadLine();

Console.WriteLine(str[1]);

