// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine(" введите цифру, обозначающую день недели: ");
int numberA = int.Parse(Console.ReadLine());
if (numberA < 8 && numberA > 0)
{
    if (numberA == 6 || numberA == 7)
    {
        Console.WriteLine(" выходной ");
    }
    else
    {
        Console.WriteLine( " Будний ");
    }
}
else
{
    Console.WriteLine(" Число выходит за диапазон (1,7) дней ");
}