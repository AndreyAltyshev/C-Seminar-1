/* 9. Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8 */

/*Без Методов 

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");
int firstDigit = number / 10;
int secondGigit = number % 10;
if (firstDigit > secondGigit) Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа => {secondGigit}"); */

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondGigit = num % 10;
    /* if (firstDigit > secondGigit) return firstDigit;
    return secondGigit; */
    int result = firstDigit > secondGigit ? firstDigit :secondGigit;        //тернарный оператор
    return result;
}
int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");