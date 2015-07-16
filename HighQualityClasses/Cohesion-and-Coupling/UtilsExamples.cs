namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileNameUtils.GetFileExtension("example"));
            Console.WriteLine(FileNameUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileNameUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", GeometryUtils.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", GeometryUtils.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            const double Width = 3;
            const double Height = 4;
            const double Depth = 5;
            Console.WriteLine("Volume = {0:f2}", GeometryUtils.CalculateVolume(Width, Height, Depth));
            Console.WriteLine("Diagonal XYZ = {0:f2}", GeometryUtils.CalculateDiagonalXYZ(Width, Height, Depth));
            Console.WriteLine("Diagonal XY = {0:f2}", GeometryUtils.CalculateDiagonalXY(Width, Height));
            Console.WriteLine("Diagonal XZ = {0:f2}", GeometryUtils.CalculateDiagonalXZ(Width, Depth));
            Console.WriteLine("Diagonal YZ = {0:f2}", GeometryUtils.CalculateDiagonalYZ(Height, Depth));
        }
    }
}
