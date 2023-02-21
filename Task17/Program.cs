/* 17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка. */

//методы
int Prompt(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int Quartyr(int x , int y)
{
    if(x>0 && y>0) return 1;
    if(x<0 && y>0) return 2;
    if(x<0 && y<0) return 3;
    if(x>0 && y<0) return 4;
    return 0;
}

//тело программы
int xc = Prompt("Введите координату X ");
int yc = Prompt("Введите координату Y ");
int quartyr = Quartyr(xc, yc);
string result = quartyr>0 ? 
                $"Указанные координаты соответствют четверти {quartyr}" 
                : "Введены не верные координаты"; 
Console.WriteLine(result);