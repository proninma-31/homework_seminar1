// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// // 	456 -> 6
// // 	782 -> 2
// // 	918 -> 8

Console.WriteLine("Введите трехзначное число");
string usernumber = Console.ReadLine();
int number = Convert.ToInt32(usernumber);
Console.Write($"Последняя цифра {number%10} ");