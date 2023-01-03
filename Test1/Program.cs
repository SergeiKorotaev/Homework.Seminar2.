Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if ((num > 999) || (num < 99))
{
 Console.WriteLine("Число не соответствует параметрам ввода");
}
else
{
 Console.WriteLine(num % 100 / 10);
}