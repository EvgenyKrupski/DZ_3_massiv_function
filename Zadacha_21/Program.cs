/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int x1 = Cordinate("x", "1");
int y1 = Cordinate("y", "1");
int z1 = Cordinate("z", "1");
int x2 = Cordinate("x", "2");
int y2 = Cordinate("y", "2");
int z2 = Cordinate("z", "2");

double numberX = Convert.ToDouble(Kvadrat(x1, x2));
double numberY = Convert.ToDouble(Kvadrat(y1, y2));
double numberZ = Convert.ToDouble(Kvadrat(z1, z2));

double r = Math.Round(Math.Sqrt(numberX + numberY + numberZ), 2);
Console.WriteLine(r);


int Cordinate(string coorName, string pointName)
{
    Console.WriteLine($"Введите {coorName} точки {pointName}");
    return Convert.ToInt32(Console.ReadLine());
}

double Kvadrat(double k1, double k2)
{
    double result = Math.Pow((k1 - k2), 2);
    return result;
}
