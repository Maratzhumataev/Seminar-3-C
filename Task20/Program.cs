Console.WriteLine("Введите координату Х точки А");
int xCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите координату Y точки А");
int yCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х точки B");
int xCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите координату Y точки B");
int yCoordinateB = Convert.ToInt32(Console.ReadLine());
double distanceAB = DistanceAB (xCoordinateA, yCoordinateA, xCoordinateB, yCoordinateB);
double distABRound = Math.Round(distanceAB, 2, MidpointRounding.ToZero);
Console.WriteLine(distABRound);

double DistanceAB (int xA, int yA, int xB, int yB)
{
    int deltaX = xA - xB;
    int deltaY = yA - yB;
    double disAB = Math.Sqrt(deltaX*deltaX + deltaY*deltaY);
    return disAB;
}
