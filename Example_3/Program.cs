//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите цифру, обозначающую день недели (1 - 7)");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 6) System.Console.WriteLine("Будний день");
else System.Console.WriteLine("Выходной");
