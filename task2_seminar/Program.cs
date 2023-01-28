//  Задача №2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница


Console.WriteLine("Введите число");
string number = Console.ReadLine();
int numberStr = Convert.ToInt32(number);

if(numberStr == 1)
{
   Console.WriteLine("Понедельник");
}
if(numberStr == 2)
{
   Console.WriteLine("Вторник");
}
if(numberStr == 3)
{
   Console.WriteLine("Среда");
}
if(numberStr == 4)
{
   Console.WriteLine("Четверг");
}
if(numberStr == 5)
{
   Console.WriteLine("Пятница");
}
if(numberStr == 6)
{
   Console.WriteLine("Субботу");
}
if (numberStr == 7)
{
   Console.WriteLine("Воскресенье");
}
