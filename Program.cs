// Напишите программу, которая принимает на вход координаиты двух точек и находит расстояние между ними
// в 3D пространстве

Console.Write ("Введите координату Х1 точки А: ");
int X1=int.Parse (Console.ReadLine());

Console.Write ("Введите координату Y1 точки А: ");
int Y1=int.Parse (Console.ReadLine());

Console.Write ("Введите координату Z1 точки A: ");
int Z1=int.Parse (Console.ReadLine());


Console.Write ("Введите координату Х2 точки Б: ");
int X2=int.Parse (Console.ReadLine());

Console.Write ("Введите координату Y2 точки Б: ");
int Y2=int.Parse (Console.ReadLine());


Console.Write ("Введите координату Z1 точки Б: ");
int Z2=int.Parse (Console.ReadLine());



int x = (X1-X2)*(X1-X2);
int y = (Y1-Y2)*(Y1-Y2);
int z = (Z1-Z2)*(Z1-Z2);

double s = Math.Sqrt(x+y+z);

Console.WriteLine($"Расстояние между точками А и Б равно {s:f3}");