//Написать программу копирования массива
Console.Write("Enter array size: ");
int k = int.Parse(Console.ReadLine()?? "");
int[] arr = new int[k];
for (int i=0; i<arr.Length; i++)
{int rnd = new Random().Next(-99,99);
arr[i] = rnd;
Console.Write($"{arr[i]} ");}
Console.WriteLine(); 
int c = arr.Length;
int[] copy = new int[c];
for (int j=0; j<c; j++) 
{copy[j] = arr[j];}
Console.WriteLine(String.Join(" ", copy));