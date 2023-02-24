/* Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

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

void ReplaceElem(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
        /* 
        if(arr[i]<0)
        {
            arr[i] = Math.Abs(arr[i]);
        }
        else
        {
            arr[i] = -arr[i];
        } */
    }
}
int Prompt(string mess)     //метод ввода
{
    Console.Write(mess);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int volume = Prompt("Сколько эллементов в массиве ");
int minElem = Prompt("минимльный эллемент массива ");
int maxElem = Prompt("Максимальный эллемент миассива ");
int[] array = CreateArrayRndInt(volume, minElem, maxElem);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Масств после обработки");
ReplaceElem(array);
PrintArray(array);
Console.WriteLine();