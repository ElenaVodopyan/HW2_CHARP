// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите трехзначние число ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 100) System.Console.WriteLine("Нет третьей цифры");
else
{
    int result = (x % 100) % 10;
    System.Console.WriteLine($"Третья цифра = {result}");
}
