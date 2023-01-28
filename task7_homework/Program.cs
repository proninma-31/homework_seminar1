//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Вводи число смертный");
string numberA = Console.ReadLine();
int A = Convert.ToInt32(numberA);
int B = 2;

if (A%B==0) {
	Console.Write($"Число {A} четное");
}
else
{
	Console.Write($"Число {A} нечетное");
}