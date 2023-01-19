/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/


int GetNum()
{
    int num = Convert.ToInt32(new Random().Next(100, 1000));
    return num;
}
int PrintSecDig(int a)
{
    int secdig = a / 10 % 10;
    return secdig;
}
int number = GetNum();
int result = PrintSecDig(number);
Console.Write($"было число: {number}, стало: {result}");
