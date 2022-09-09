// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("Введите трехзначние число ");
int x = Convert.ToInt32(Console.ReadLine());
int result = ( x / 10 ) %  10;
System.Console.WriteLine($"Вторая цифра = {result}");