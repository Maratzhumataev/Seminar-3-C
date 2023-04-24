// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату Х точки А");
int xCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите координату Y точки А");
int yCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите координату Z точки А");
int zCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х точки B");
int xCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите координату Y точки B");
int yCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите координату Z точки B");
int zCoordinateB = Convert.ToInt32(Console.ReadLine());

double DistanceAB (int xA, int yA, int zA, int xB, int yB, int zB)
{
    int deltaX = xA - xB;
    int deltaY = yA - yB;
    int deltaZ = zA - zB;
    double disAB = Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);
    return disAB;
}

double distanceAB = DistanceAB (xCoordinateA, yCoordinateA, zCoordinateA, xCoordinateB, yCoordinateB, zCoordinateB);
double distABRound = Math.Round(distanceAB, 2, MidpointRounding.ToZero);
Console.WriteLine(distABRound);