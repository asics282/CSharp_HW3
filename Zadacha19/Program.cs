// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int NewNumber = number; // задаем новую переменную, которую будет сравнивать с заданным числом
int result = 0; // переменная для хранения перепернутого числа
while (number!=0) // цикл для перепорачивания числа
{
    int x = number%10; // вычисляем последнюю цифру числа
    result = result*10 + x;
    number = (number/10); // делим без остатка чтобы перейти к следующей цифре
}
if (result==NewNumber)
{
    Console.WriteLine($"{number} -> да");
}
else 
{
    Console.WriteLine($"{number} -> нет");
}
