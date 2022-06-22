//2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница
Console.Write("Введите номер дня недели -> ");
string numberString = Console.ReadLine();
int number = int.Parse(numberString);

if (number < 1 || number>7)
{
    Console.Write("это не день недели");
}

if (number == 1)
{
    Console.Write("день недели понедельник");
}
if (number == 2)
{
    Console.Write("день недели вторник");
}
if (number == 3)
{
    Console.Write("день недели среда");
}
if (number == 4)
{
    Console.Write("день недели четверг");
}
if (number == 5)
{
    Console.Write("день недели пятница");
}
if (number == 6)
{
    Console.Write("день недели суббота");
}
if (number == 7)
{
    Console.Write("день недели воскресенье");
}

