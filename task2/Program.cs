/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

int GetNum()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int LeightNum(int a)
{
    char[] b = a.ToString().ToCharArray();
    int leight = b.Length;
    return leight;
}
char[] NumToArray(int name, int size)
{
    char[] array = new char[size];
    array = name.ToString().ToCharArray();
    return array;
}
Console.WriteLine("Введите число: ");
int numbers = GetNum();
int lein = LeightNum(numbers);
char[] array = NumToArray(numbers, lein);
if (lein < 3) Console.WriteLine($"у числа {numbers} нету 3-ий цифры");
else
{
    Console.WriteLine($"у числа '{numbers}' 3-ая цифра: {array[2]}");
}

