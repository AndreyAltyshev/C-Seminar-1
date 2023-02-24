/* Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int Prompt(string mess)     //метод ввода
{
    Console.Write(mess);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool CheckDigit(int[] arr, int dig)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == dig) return true;
    }
    return false;
}
int volume = Prompt("Сколько эллементов в массиве ");
int minElem = Prompt("минимльный эллемент массива ");
int maxElem = Prompt("Максимальный эллемент миассива ");
int[] array = CreateArrayRndInt(volume, minElem, maxElem);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine();
int elem = Prompt("какой эллемент искать? ");
if (CheckDigit(array, elem)) Console.WriteLine("Такой эллемент есть");
else Console.WriteLine("Такого эллемента нет");