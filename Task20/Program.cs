/* Задача 20: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

//методы
int Prompt(string message)
{
    Console.WriteLine(message);
    Console.Write("X=");
    int xc = Convert.ToInt32(Console.ReadLine());
 
    Console.Write("Y=");
    int yc = Convert.ToInt32(Console.ReadLine());
    return yc;
}
//тело программы
Console.WriteLine("Введите координаты точки А:");
int a = Prompt("X=");
int b = Prompt("");
Console.WriteLine(a);
Console.Write("Введите координаты x точки a: ");










/* int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y точки a: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты x точки b: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y точки b: ");
int yb = Convert.ToInt32(Console.ReadLine());

double result = Distance(xa, ya, xb, yb);
Console.Write(Math.Round(result, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int x2, int y2)
{
    double sumSquare = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
    double res = Math.Sqrt(sumSquare);
    return res;
} */