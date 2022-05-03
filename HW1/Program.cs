//программа, принимающая 3 числа и выдающее максимальное из них
Console.WriteLine("введите число 1");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 3");
int numberC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("максимальное число равно ");
if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.WriteLine(numberA);
    }
    else
        Console.WriteLine(numberC);
}
else 
    if (numberB > numberC)
    {
        Console.WriteLine(numberB);
    }
    else
        Console.WriteLine(numberC);
