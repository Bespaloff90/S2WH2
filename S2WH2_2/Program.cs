// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Hello,it's you?! Ok, enter your number:  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number > 99 ? number.ToString()[2] : "no digit");