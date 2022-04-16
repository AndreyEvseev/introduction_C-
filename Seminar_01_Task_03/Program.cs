// Семинар 1, задача 3

int dayNum = 11;

if (dayNum == 1)
{
    Console.WriteLine("Числу 1 соответствует день недели Понедельник");
}
else
{
    if (dayNum == 2)
    {
        Console.WriteLine("Числу 2 соответствует день недели Вторник");
    }
    else
    {
        if (dayNum == 3)
        {
            Console.WriteLine("Числу 3 соответствует день недели Среда");
        }
        else
        {
            if (dayNum == 4)
            {
                Console.WriteLine("Числу 4 соответствует день недели Четверг");
            }
            else
            {
                if (dayNum == 5)
                {
                    Console.WriteLine("Числу 5 соответствует день недели Пятница");
                }
                else
                {
                    if (dayNum == 6)
                    {
                        Console.WriteLine("Числу 6 соответствует день недели Суббота");
                    }
                    else
                    {
                        if (dayNum == 7)
                        {
                            Console.WriteLine("Числу 7 соответствует день недели Воскресенье");
                        }
                        else
                        {
                            Console.WriteLine($"Для числа {dayNum} нет соответствующего дня недели");
                        }
                    }
                }
            }
        }
    }
}

