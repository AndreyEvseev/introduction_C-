// 4. Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23

int number = 161;
int divisor1 = 7, divisor2 = 23;
if(number % divisor1 == 0 && number % divisor2 == 0) Console.WriteLine("Да");
else Console.WriteLine("Нет");
