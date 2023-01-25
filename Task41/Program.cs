/*
Задача 41. Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввел пользователь.
0,7,8,-2,-2 -> 2
-1,-7,567,89,223 -> 3
*/

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getCountOfPositiveNumbers (int countOfNumbers)
{
    int count = 0;
    for (int i = 1; i <= countOfNumbers; i++)
    {
        int number = getUserData ($"Введите число {i}");
        if (number > 0) count = count + 1;
    }
    return count;
}

int userCountOfNumbers = getUserData ("Задайте количество чисел:");
int count = getCountOfPositiveNumbers (userCountOfNumbers);
Console.WriteLine ($"В указанных числах {count} чисел больше 0");