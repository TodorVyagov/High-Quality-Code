using System;

namespace CohesionAndCoupling
{
    class Examples
    {
        static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                GeometryUtils.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                GeometryUtils.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            int width = 3;
            int height = 4;
            int depth = 5;
            Console.WriteLine("Volume = {0:f2}", GeometryUtils.CalculateVolume(width, height, depth));
            Console.WriteLine("Diagonal XYZ = {0:f2}", GeometryUtils.CalculateDiagonal3D(width, height, depth));
            Console.WriteLine("Diagonal XY = {0:f2}", GeometryUtils.CalculateDiagonal2D(width, height));
            Console.WriteLine("Diagonal XZ = {0:f2}", GeometryUtils.CalculateDiagonal2D(width, depth));
            Console.WriteLine("Diagonal YZ = {0:f2}", GeometryUtils.CalculateDiagonal2D(height, depth));
        }
    }
}
