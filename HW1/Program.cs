
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

if (numOne > numTwo) {
    Console.WriteLine($"{numOne} > {numTwo}");
}
if (numOne < numTwo) {
    Console.WriteLine($"{numOne} < {numTwo}");
}
if (numTwo > numOne) {
    Console.WriteLine($"{numTwo} > {numOne}");
}
if (numTwo < numOne) {
    Console.WriteLine($"{numTwo} < {numOne}");
}





