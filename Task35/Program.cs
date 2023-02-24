/* Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

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
int CountIfRangeArr(int[] arr, int minRange, int maxRange)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= minRange && arr[i] <= maxRange) count = count + 1;
    }
    return count;
}
// programm
int volume = Prompt("Сколько эллементов в массиве ");
int minElem = Prompt("минимльный эллемент массива ");
int maxElem = Prompt("Максимальный эллемент миассива ");
int[] array = CreateArrayRndInt(volume, minElem, maxElem);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("отборка из какого диапазона? ");
int minrange = Prompt("от ");
int maxrange = Prompt("до ");
Console.WriteLine($"Колличество эл-ов массива лежащих в отрезке [{minrange}, {maxrange}]: {CountIfRangeArr(array, minrange, maxrange)}");