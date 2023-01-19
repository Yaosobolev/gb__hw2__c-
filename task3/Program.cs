/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
int GetNum()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int holidays(int a)
{
    if (a >= 1 && a <= 5) return 1;
    else if (a == 6 || a == 7) return 2;
    else return 0;
}
Console.WriteLine("Введите число, и узнайте в этот день выходной или нет  ");
int number = GetNum();
int result = holidays(number);
switch (result)
{
    case 1:
        Console.WriteLine($"К сожалению это будни");
        break;
    case 2:
        Console.WriteLine($"Поздравляю, это выходной");
        break;
    default:
        Console.WriteLine($"Такого дня не существует");
        break;
}
