 //задача, которое принимает на вход одно значение, а на выходе выводит обратное ( 4 -- 0.25, 8 -- 0.125)
 Console.WriteLine("введите число");
 double number = Convert.ToInt32(Console.ReadLine());
 if (number == 0)
 {
     Console.WriteLine("на ноль делить нельзя");
 }
 else
 {
 double obr = 1 / number;
 Console.Write("обратное число равно ");
 Console.WriteLine(obr);
 }