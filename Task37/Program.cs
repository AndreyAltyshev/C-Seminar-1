/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

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

int[] MultiplArrayElement(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 != 0) newArr[newArr.Length - 1] = arr[size - 1];
    return newArr;
}

int volume = Prompt("Сколько эллементов в массиве ");
int minElem = Prompt("минимльный эллемент массива ");
int maxElem = Prompt("Максимальный эллемент миассива ");
int[] array = CreateArrayRndInt(volume, minElem, maxElem);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine();
int[] array2 = MultiplArrayElement(array);
PrintArray(array2);