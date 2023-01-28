// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Вводи первое число смертный");
string numberA = Console.ReadLine();
Console.WriteLine("Теперь второе число");
string numberB = Console.ReadLine();
int NumberA =Convert.ToInt32(numberA);
int NumberB = Convert.ToInt32(numberB);

if (NumberA > NumberB)
{
	Console.Write($"Большее число: {NumberA} ");
}
else
{
	Console.Write($"Большее число:{NumberB} ");
}