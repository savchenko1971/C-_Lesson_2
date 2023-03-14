// Напишите программу, которая на вход притимает число и выдает его 
// квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 ->49

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32( Console.ReadLine() );
int square = num * num;
Console.WriteLine("Квадрат введенного числа равен " + square);
