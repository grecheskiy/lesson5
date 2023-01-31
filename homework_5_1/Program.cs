//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, 
//y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.Write("Enter k1: ");
double k1 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter b1: ");
double b1 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter k2: ");
double k2 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter b2: ");
double b2 = double.Parse(Console.ReadLine() ?? "0");
//k1*x+b1=k2*x+b2 -> x=(b2-b1)/(k1-k2) 
//y=k1(b2-b1)/(k1-k2)+b1 
double x=(b2-b1)/(k1-k2); 
double y=k1*(b2-b1)/(k1-k2)+b1;
//double x = -(b1 - b2) / (k1 - k2);
//double y = k1 * x + b1;
x = Math.Round(x, 3);
y = Math.Round(y, 3);
Console.WriteLine($"cross of lines at a point: ({x};{y})");