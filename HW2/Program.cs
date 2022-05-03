// Программа, определяющая, чётное ли число
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int ostatok = number%2;
if (ostatok == 1)
{
    Console.WriteLine("число нечётное");
}
else 
Console.WriteLine("число чётное");