//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает 
//все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число для вычесления => ");
string Nstring = Console.ReadLine();
int N = int.Parse(Nstring);
int Nstart = (N+1);
N=-N;
while(N<Nstart)
{
   Console.Write($"{N}, ");
   N++; 
}