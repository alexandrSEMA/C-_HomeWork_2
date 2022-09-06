// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
string nameA = Console.ReadLine();
int numberA = Convert.ToInt32(nameA);
string numberB = Convert.ToString(numberA);
if (numberB.Length > 2)
{
  Console.WriteLine(numberB[2]);
}
else
{
  Console.WriteLine("третьей цифры нет");
}