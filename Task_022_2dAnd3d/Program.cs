// 22. Найти расстояние между точками в пространстве 2D/3D

void distanceSpace(double x1, double x2, double y1, double y2, double z1, double z2)
{
        double distance2 = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
        double distance2d = Math.Sqrt(distance2);
        Console.WriteLine($"Растояние в пространстве 2D = {distance2d}.");
   
        double distance3 = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1));
        double distance3d = Math.Sqrt(distance3);
        Console.WriteLine($"Растояние в пространстве 3D = {distance3d}.");
}

distanceSpace(1, 5, 2, 6, 7, 9);

//Второй способ

double distance2D(double x1, double x2, double y1, 
                double y2)
{
        return Math.Sqrt(Math.Pow(x2 - x1, 2) 
                        + Math.Pow(y2 - y1, 2));
}
Console.WriteLine("Растояние в 2D " +distance2D(1, 5, 2, 6));

double distance3D(double x1, double x2, double y1, 
                double y2, double z1, double z2)
{
        return Math.Sqrt(Math.Pow(x2 - x1, 2) 
                        + Math.Pow(y2 - y1, 2) 
                        + Math.Pow(z2 - z1, 2));
}
Console.WriteLine("Растояние в 3D " +distance3D(1, 5, 2, 6, 7, 9));