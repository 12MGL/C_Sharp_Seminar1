// Задача, выдающая все чётные числа от 1 до введённого
Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    Console.Write("введите число больше 1");
}
else
{
    if (number == 0)
    {
        Console.WriteLine("число 0 - чётное");
    }
    else
    {
        if (number == 1)
        {
            Console.Write("Введите число больше 1");
        }
        else
        {
            Console.WriteLine("Чётные числа от 1 до введённого: ");
            for (int count = 2; count < number+1; count++)
            {
                if (count%2==0)
                {
                    Console.Write(count);
                    Console.Write(" ");
                }
            }
        }
    }
}