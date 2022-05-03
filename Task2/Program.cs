//программа, которая выдаёт название дня недели по номеру
Console.WriteLine("введите номер дня недели (1-7)");
int weekday = Convert.ToInt32(Console.ReadLine());
if (weekday == 1)
{
    Console.WriteLine("это понедельник");
}
else
if (weekday == 2)
{
    Console.WriteLine("это вторник");
}
else
if (weekday == 3)
{
    Console.WriteLine("это среда");
}
else
if (weekday == 4)
{
    Console.WriteLine("это четверг");
}
else
if (weekday == 5)
{
    Console.WriteLine("это пятница");
}
else
if (weekday == 6)
{
    Console.WriteLine("это суббота");
}
else
if (weekday == 7)
{
    Console.WriteLine("это воскресенье");
}
else 
{
    Console.WriteLine("неправильный ввод");
}