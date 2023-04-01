
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
System.Console.WriteLine("Введите первое число: ");
string one = Console.ReadLine();
System.Console.WriteLine("Введите второе число: ");
string two = Console.ReadLine();

int numOne = Convert.ToInt32(one);
int numTwo = Convert.ToInt32(two);

if (numOne > numTwo)
{
    Console.WriteLine($"{numOne} > {numTwo}");
}
if (numOne < numTwo)
{
    Console.WriteLine($"{numOne} < {numTwo}");
}
if (numTwo > numOne)
{
    Console.WriteLine($"{numTwo} > {numOne}");
}
if (numTwo < numOne)
{
    Console.WriteLine($"{numTwo} < {numOne}");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
System.Console.WriteLine("Введите первое число: ");
string? one = Console.ReadLine();
int numOne = Convert.ToInt32(one);

System.Console.WriteLine("Введите второе число: ");
string? two = Console.ReadLine();
int numTwo = Convert.ToInt32(two);

System.Console.WriteLine("Введите третье число: ");
string? three = Console.ReadLine();
int numThree = Convert.ToInt32(three);

int max = numOne;

if (numTwo > numOne)
{
    max = numTwo;
    if (numThree > numTwo)
    {
        max = numThree;
    }
}
else if (numThree > numOne)
{
    max = numThree;
}

Console.WriteLine("Максимальное число: " + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
System.Console.WriteLine("Введите число: ");
string? one = Console.ReadLine();
int numOne = Convert.ToInt32(one);

if (numOne % 2 == 0)
{
    Console.WriteLine($"Число {numOne} является четным!");
    return;
}
Console.WriteLine($"Число {numOne} НЕ является четным!");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
System.Console.WriteLine("Введите число N: ");
string? n = Console.ReadLine();
int numN = Convert.ToInt32(n);

for (int i = 1; i <= numN; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"Число {i} является четным!");
    }
}