//Написать программу масштабирования фигуры например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
double[] arr = { 0.0, 2.0, 2.2, 0.2 };
foreach (double item in arr)
{Console.Write($"{item} ");}
Console.WriteLine();
Console.Write("enter the scaling factor: ");
int k = int.Parse(Console.ReadLine()?? "");
for (int i=0; i<arr.Length; i++)
{arr[i] = arr[i] * k;
Console.Write($"{arr[i]} ");}
Console.WriteLine();