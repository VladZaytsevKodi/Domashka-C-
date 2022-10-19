// Напишите программу, которая на вход принимает трехзначное число и на выходе
//выдает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int num1 = int.Parse(Console.ReadLine()!);

int ThreeTwoDigit = num1 % 100;
int TwoDigit = ThreeTwoDigit / 10;

Console.WriteLine(TwoDigit);


/*int TwoDigit(int num1)
{
    return num1 % 100;
}
Console.WriteLine(TwoDigitint(num1));*/

/*int testnumber = 5123;
int lastDigit = GetlastDigit(testnumber);

Console.WriteLine(lastDigit);*/
