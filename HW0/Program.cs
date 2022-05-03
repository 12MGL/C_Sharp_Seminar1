//программа, принимающая 2 числа, и выдающая, какое из них большее, какое - меньшее
Console.WriteLine("введите число 1");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA < numberB)
{
    Console.WriteLine("второе число больше");
}
else
if (numberA > numberB)
{
    Console.WriteLine("первое число больше");
}
else 
Console.WriteLine("числа равны");