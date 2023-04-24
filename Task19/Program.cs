// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (((number / 10000) < 10) && (number > 0)) 
{
    bool result = Result(number);
    Console.WriteLine(result == true ? "Число является палиндромом" : "Число не является палиндромом");
}
else Console.WriteLine("Число не является положительным пятизначным");

bool Result (int num)
{
    if ((num / 10000) == (num % 10))
    {
        if (((num / 1000) % 10) == (((num % 100) / 10))) return true;
    }
    return false;
}