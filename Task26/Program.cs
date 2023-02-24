/* Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

//тело программы
int number = Prompt("Введите число ");
int diget = CheckDigit(number);
Console.WriteLine($"В числе {number}, {diget} ");

//методы
int Prompt(string mess)     //метод ввода
{
    Console.Write(mess);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int CheckDigit(int num)
{
    int result = 0;
    if (num == 0) return 1;
    else
    {
        while (num != 0)
        {
            num = num / 10;
            result = result + 1;
        }
    }
    return result;
}