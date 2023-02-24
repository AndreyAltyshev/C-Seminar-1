/* Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120 */
int number = Prompt("Введите целое положительное число N=");
int factorial = Factorial(number);
if (Nature(number)) Console.WriteLine($" {number}!={factorial}");
else Console.WriteLine("введено не натуральное число");

//методы
int Prompt(string mess)     //метод ввода
{
    Console.Write(mess);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool Nature(int num)    //метод проверки на натуральность
{
    return num > 0;
}
int Factorial(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            factorial = factorial * i;
        }
    }
    return factorial;
}