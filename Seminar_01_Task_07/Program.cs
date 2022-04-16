// Семинар 1, задача 7

int number = 918;
if (number > 999 && number < 99)
{
        Console.WriteLine("Ошибка! Введено не трехзначное число");
}
int digit = number % 10;
Console.WriteLine(digit);
