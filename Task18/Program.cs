internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите номер четверти");
        int quarter = Convert.ToInt32(Console.ReadLine());
        string coordinate = Coordinate(quarter);
        Console.WriteLine(coordinate == null ? "неправильный номер четверти" : coordinate);

        string Coordinate(int quart)
        {
            if (quart == 1) return "x > 0 && y >0 ";
            if (quart == 2) return "x < 0 && y > 0";
            if (quart == 3) return "x < 0 && y < 0";
            if (quart == 4) return "x > 0 && y < 0";
            return null;
        }
    }
}