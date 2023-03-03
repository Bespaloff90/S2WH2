// Напишите программу, которая принимает на вход 
// ятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

  Console.Write("Enter the number polyndrom:  ");
            int number = int.Parse(Console.ReadLine());
            int pal = 0, num = number;
            while (number > 0) {pal = pal * 10 + number % 10; number /= 10;}
            Console.WriteLine(num == pal ? "палиндром" : "не палиндром");