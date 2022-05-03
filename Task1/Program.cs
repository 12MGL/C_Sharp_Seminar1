//Написать программу, проверяющую, является ли первое число квадратом второго
Console.WriteLine("введите число-квадрат");
int square = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int realsquare = number*number;
if (square == realsquare)
{
    Console.WriteLine("правильно");
}
else
{
    Console.WriteLine("неправильно");
}