// Напишите программу, которая выводит третью цифру заданного числа или сщщбщает,
//что третьей цифры нет

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if(num > 1000)
{   
    int i = num;
    while (i > 1000)
    {
        i = i /10;
    }
        int ThreeDigit = i % 10;
        Console.WriteLine(ThreeDigit);

}     
else
    if (num > 100)
   {
      int ThreeDigit = num % 10;
      Console.WriteLine(ThreeDigit);  
   }
    else
   {
    Console.WriteLine("нет третьей цифры");
   }

