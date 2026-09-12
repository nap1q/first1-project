////Вариант 10 Средний

//Console.WriteLine("Введите y:");
//double y = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите t:");
//double t = double.Parse(Console.ReadLine());
//double Z = ((2 * t) + (Math.Cos(y) * t)) / (Math.Exp(0) + 4.831);
//Console.WriteLine($"Z={Z:F2}");

//Вариант 10 Высокий

Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
double U = (Math.Exp(3) + Math.Cos(x - 4)* Math.Cos(x - 4)) / (Math.Atan(x) + (5.2 * y));
Console.WriteLine($"U={U:F2}");

