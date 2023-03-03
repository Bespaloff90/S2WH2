
Console.WriteLine("Введите координаты, 6 чисел через пробел");
{
    double[] x = new double[6];
    double d, distance = 0.0;
    Console.WriteLine("x1 y1 z1 x2 y2 z3:");
    var line = Console.ReadLine().Split();
    for (int i = 0; i < 3; i++)
    {
        d = Convert.ToDouble(line[i + 3])
    - Convert.ToDouble(line[i]);
        distance += d * d;
    }
    Console.WriteLine("r = " + Math.Sqrt(distance));
}