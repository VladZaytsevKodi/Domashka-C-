// Напишите программу, которая на вход принимает число и выдаёт является ли оно чётным
Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);

if(num1 % 2 == 0)
{
    Console.WriteLine("число является четным");   
}
else
{
    Console.WriteLine("число является нечетным");
}