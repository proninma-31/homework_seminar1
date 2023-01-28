//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Вводи первое число смертный");
string numberA = Console.ReadLine();
Console.WriteLine("Теперь второе число");
string numberB = Console.ReadLine();
Console.WriteLine("Ну и наконец третье число");
string numberC = Console.ReadLine();
int A =Convert.ToInt32(numberA);
int B = Convert.ToInt32(numberB);
int C = Convert.ToInt32(numberC);
int maxnumber = A;
if (maxnumber>B){
	maxnumber=A;
}
else {
	maxnumber = B;
}
if (maxnumber>C){
	Console.Write($"Большее число: {maxnumber} ");
}
else{
	maxnumber=C;
	Console.Write($"Большее число: {maxnumber} ");
}