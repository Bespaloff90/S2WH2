// Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

string[] days = { "Monday", "Tuesday", "Wenesday", "Thursday", "Friday", "Saturday", "Sunday" };
Console.Write("Hello,it's you?! Ok, enter your daynumber:  ");
int daynumber = Convert.ToInt32(Console.ReadLine());
if (daynumber > 7 | daynumber < 1)
{
    Console.WriteLine("God did not invent such a day");
}
if (daynumber <= 5)
{
    Console.WriteLine(days[daynumber - 1]);
    Console.WriteLine("Work Hard");
}
if (daynumber == 6 | daynumber == 7)
{
    Console.WriteLine(days[daynumber - 1]);
    Console.WriteLine("Yes!!! It's day off, let's go party");
}