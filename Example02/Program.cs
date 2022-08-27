// Напишите программу, оторая на вход принимает два числа
// и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

System.Console.Clear();

System.Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA > numberB)
{
    Console.WriteLine(numberA);
}
else
{
    Console.WriteLine(numberB);
}