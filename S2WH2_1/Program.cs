// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Hello, friend");
Console.Write("Enter your number:   ");
int number = Convert.ToInt32(Console.ReadLine());
int firsrdigit = number/10;
int resultfirstdigit = firsrdigit%10;
Console.WriteLine(resultfirstdigit);



