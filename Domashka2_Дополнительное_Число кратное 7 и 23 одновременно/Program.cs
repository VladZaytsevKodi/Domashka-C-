// Напишите программу, которая на вход принимает число и проверяет кратно ли оно одновременно 7 и 23
Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);

if(num1 % 7 == 0)
{
    if(num1 % 23 == 0)
    {
        Console.WriteLine("да");   
    }   
}
else
{
    Console.WriteLine("нет");
}