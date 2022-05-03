//задача, которая принимает на вход одно число (N), а на выходе выдаёт все целые числа в промежутке от -N до N
Console.WriteLine("Введите положительное число (не берите слишком большие числа - желательно от 0 до 20");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;
if (N < 0)
{
    Console.Write("введите число БОЛЬШЕ 0 и меньше 20");
}
else
Console.WriteLine("В промежутке от -N до N имеются следующие целые числа");
while (count <= N)
{
    Console.Write(count);
    Console.Write(" ");
    count++;
}