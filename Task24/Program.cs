/* Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

//тело программы
int number = Prompt("Введите целое положительное число A=");
int sum = SumNumbers(number);
if (Nature(number)) Console.WriteLine($"Сумма чисел от 1 до {number} равна {sum}");
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
int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum = sum + i;
        }
    }
    return sum;
}