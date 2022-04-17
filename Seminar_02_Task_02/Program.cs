// 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа

int number2 = new Random().Next(10, 100);
Console.Write(number2 + ", ");
if(number2 / 10 > number2 % 10) Console.WriteLine(number2 / 10);
else Console.WriteLine(number2 % 10);
