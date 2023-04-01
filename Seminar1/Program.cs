// See https://aka.ms/new-console-template for more information

System.Console.WriteLine("Enter number: ");
string strNum = Console.ReadLine();
int number = Convert.ToInt32(strNum);


double sqrDb = Math.Pow(number, 2);
int sqr = Convert.ToInt32(sqrDb);


// int sqr = number * number;
// if (sqr < 0) {
//     sqr *= -1;
// }

Console.WriteLine($"sqr = {sqr}");

System.Console.WriteLine("Enter first number: ");
string one = Console.ReadLine();
System.Console.WriteLine("Enter second number: ");
string two = Console.ReadLine();

int numOne = Convert.ToInt32(one);
int numTwo = Convert.ToInt32(two);

if (Math.Pow(numOne, 2) == numTwo) {
    Console.WriteLine("Первое число является квадратом второго");
} else {
    Console.WriteLine("Первое число НЕ является квадратом второго");
}



Console.WriteLine("Enter weekday number: ");
string? numDay = Console.ReadLine();
if (numDay == null)
{
    return;
}
// string weekDay = "Ввод должен быть от 1 до 7!";
// if (numDay == "1") {
//     weekDay = "Понедельник";
// } else if (numDay == "2") {
//     weekDay = "Вторник";
// } else if (numDay == "3") {
//     weekDay = "Среда";
// } else if (numDay == "4") {
//     weekDay = "Четверг";
// } else if (numDay == "5") {
//     weekDay = "Пятница";
// } else if (numDay == "6") {
//     weekDay = "Суббота";
// } else if (numDay == "7") {
//     weekDay = "Воскресенье";
// }
string weekDay = "";
switch (numDay)
{
    case "1":
        weekDay = "Понедельник";
        break;
    case "2":
        weekDay = "Вторник";
        break;
    case "3":
        weekDay = "Среда";
        break;
    case "4":
        weekDay = "Четверг";
        break;
    case "5":
        weekDay = "Пятница";
        break;
    case "6":
        weekDay = "Суббота";
        break;
    case "7":
        weekDay = "Воскресенье";
        break;
    default:
        weekDay = "Ввод должен быть от 1 до 7!";
        break;

}

Console.WriteLine(weekDay);