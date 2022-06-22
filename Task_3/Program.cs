// Напишите программу вычисления функции:
// x = a в кубе


Console.Write("Введите число для возведения в куб => ");
string astring = Console.ReadLine();
int a = int.Parse(astring);
int x = (a*a*a);
Console.Write($"{a} в кубе будет {x}");