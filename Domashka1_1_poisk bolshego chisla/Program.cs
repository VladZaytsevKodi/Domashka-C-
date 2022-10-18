//Напиштитепрограмму, которая на вход принимает два числа и выдаёт, какое число большее,
// а какое меньшее.
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
if(num1>num2)
{
    Console.WriteLine("первое число большее");
    Console.WriteLine("второе число меньшее");
}
else
{
    Console.WriteLine("второе число большее");
    Console.WriteLine("первое число меньшее");
}