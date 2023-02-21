/* Задача 22: Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

//тело программы
int number = Prompt("Введите число N ");
if (number > 0) SquarN(number);
else Console.WriteLine("введено не верное значение");

//методы
int Prompt(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void SquarN(int k)
{
    for (int i = 1; i <= k; i++)
    {
        Console.WriteLine($"{i}      {Math.Pow(i, 2)}");
    }
    return;
}