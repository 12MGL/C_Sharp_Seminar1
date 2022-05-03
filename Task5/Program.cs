//вычисление модуля числа
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("модуль введённого числа равен");
if (number < 0)
{
    number = -number;

}
Console.WriteLine(number);