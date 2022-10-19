// Напишите программу, которая выводит слчайное трехзначное число и 
//удаляет вторую цифру этого числа

int Threedigit = new Random().Next(100, 1000);
Console.WriteLine(Threedigit);

int FirstDigit = Threedigit / 100;
Console.Write(FirstDigit);
int ThreeDigit = Threedigit % 10;
Console.WriteLine(ThreeDigit);

/*Console.WriteLine("Введите трехзначное число: ");
int num1 = int.Parse(Console.ReadLine()!);

int ThreeTwoDigit = num1 % 100;
int TwoDigit = ThreeTwoDigit / 10;

Console.WriteLine(TwoDigit);*/
