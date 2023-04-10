/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */
Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = 1;
if (numberB < 1)
{
    Console.WriteLine("Число В должно быть натуральным");
}
else
{
    while (numberB!=0)
    {
        numberC = numberC * numberA;
        numberB = numberB - 1;
    }
    Console.WriteLine($"Число А в натуральной степени В равно {numberC}");
}