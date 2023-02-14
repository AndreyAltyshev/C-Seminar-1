//3. Напишите программу, которая будет выдавать
//название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница
Console.WriteLine("Введите номер дня недели");
string day = Console.ReadLine();
if (day == "1") Console.Write("Понедельник");
else if (day == "2") Console.Write("Вторник");
else if (day == "3") Console.Write("Среда");
else if (day == "4") Console.Write("Четверг");
else if (day == "5") Console.Write("Пятница");
else if (day == "6") Console.Write("Суббота");
else if (day == "7") Console.Write("Воскресение");
else Console.Write("Такого дня не существует :) ");