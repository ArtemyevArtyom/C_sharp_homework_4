/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

int getTheSumOfTheDigits(int number)
{
    int count = 0;
    int result = 0;
    while (userNumber > 0 || userNumber < 0)
    {
       result = userNumber % 10;
       count += result; 
       userNumber = userNumber / 10;
    }
    return count;
}

int sum = getTheSumOfTheDigits(userNumber);
Console.WriteLine($"Сумма чисел равна {sum}");