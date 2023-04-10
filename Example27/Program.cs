/* 
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int length = Length(numberA);
Console.Write($"Сумма цифр в числе {numberA} равно {Sum(numberA, length)}");
int Length(int numberA)
{
    int index = 0;
    while (numberA > 0)
    {
        numberA/=10;
        index++;
    }
    return index;
}
int Sum(int numberA, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum+=numberA%10;
        numberA/=10;
    }
    return sum;
}