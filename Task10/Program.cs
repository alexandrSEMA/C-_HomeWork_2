//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
string nameA = Console.ReadLine();
int numberA = Convert.ToInt32(nameA);
string numberB = Convert.ToString(numberA);
Console.Write("Второе число из трех = ");
Console.WriteLine(numberB[1]);