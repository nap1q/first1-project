////высокий 
//Console.Write("Введите x: ");
//double x = double.Parse(Console.ReadLine());
//double K = (Math.Sqrt(Math.Pow(3+x, 6) - Math.Log
//    (x))) / (Math.Exp(0)+Math.Asin(6*x*x));
//Console.WriteLine($"K={K:F2}");

////базовый 
//Console.WriteLine("Введите y: ");
//double y = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите r: ");
//double r = double.Parse

//Вариант 10 

Console.WriteLine("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.WriteLine("Введите t:");
double t = double.Parse(Console.ReadLine());
double Z = ((2 * t) + (Math.Cos(y) * t)) / (Math.Exp(0) + 4.831);
Console.WriteLine($"Z={Z:F2}");

