﻿Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    Console.WriteLine("Третья цифра в числе "+num.ToString()+" = "+num.ToString()[2]);
}
else
{
    Console.WriteLine("Третья цифра отсутствует");
}