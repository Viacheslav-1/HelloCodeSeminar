//1. Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго.
//a = 5; b = 25 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> нет
//a = -3 b = 9 -> да


Console.Write("Введите первое число-> ");
string firstString = Console.ReadLine();
Console.Write("Введите второе число-> ");
string secondString = Console.ReadLine();
int firstInt = int.Parse(firstString);
int secondtInt = int.Parse(secondString);
if (secondtInt * secondtInt == firstInt)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}