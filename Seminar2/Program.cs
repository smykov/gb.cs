Console.WriteLine("\nПрограмма, которая выводит случайное число из отрезка [10, 99] и показывает набольшую цифру числа.");
// Например
// 78 -> 8
// 12 -> 2
// 85 -> 8

int num = new Random().Next(10, 100);

int num1 = num / 10;
int num2 = num % 10;

Console.WriteLine(num);

if (num1 > num2)
{
    Console.WriteLine($"num1 > num2, max = {num1}");
}
else if (num1 < num2)
{
    Console.WriteLine($"num1 < num2, max = {num2}");
}
else
{
    Console.WriteLine($"num1 == num2, max = {num1}");
}

/*
Console.WriteLine("\nПрограмма, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.");
// Например
// 456 -> 46
// 782 -> 72
// 918 -> 98

int numRandom = new Random().Next(100, 1000);

int numOne = numRandom / 100;
int numTwo = numRandom % 10;

Console.WriteLine(numRandom);

int result = numOne * 10 + numTwo;

Console.WriteLine(result);


Console.WriteLine("\nПрограмма, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.");
// Например
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
string? first = Console.ReadLine();
int numFirst = int.Parse(first ?? "");
Console.WriteLine("Введите второе число: ");
string? second = Console.ReadLine();
int numSecond = int.Parse(second ?? "");

int diff = numFirst % numSecond;

if (diff == 0)
{
    Console.WriteLine($"Число {numFirst} и {numSecond} кратны.");
}
else
{
    Console.WriteLine($"Число {numFirst} и {numSecond} НЕ кратны, остаток {diff}.");
}
*//*
Console.WriteLine("\nПрограмма, которая принимает на вход число и проверяет, кратно ли оно одновременно");
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
string? str = Console.ReadLine();
int number = int.Parse(str ?? "");

if ((number % 7 == 0) && (number % 23 == 0))
{
    Console.WriteLine($"Число {number} кратно 7 и 23.");
}
else
{
    Console.WriteLine($"Число {number} НЕ кратно 7 и 23.");
}
*/

Console.WriteLine("\nПрограмму, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.");

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число: ");
int numOne = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе число: ");
int numTwo = int.Parse(Console.ReadLine() ?? "");

int min = Math.Min(numOne, numTwo);
int max = Math.Max(number1, number2);

if ((Math.Pow(min, 2)) == max)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

