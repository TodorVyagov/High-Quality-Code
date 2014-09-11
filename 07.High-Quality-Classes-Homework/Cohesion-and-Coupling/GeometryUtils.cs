using System;

namespace CohesionAndCoupling
{
    static class GeometryUtils
    {
        // 2D and 3D methods could be extracted in different classes, but now you can use all geometry methods only by GeometryUtils class.
        // There were 3 same methods calculating Diagonal, so I deleted 2 of them.

        /// <summary>
        /// Calculates the distance between two points in the 2D Euclidean space.
        /// </summary>
        /// <param name="x1">First point x-coordinate.</param>
        /// <param name="y1">First point y-coordinate.</param>
        /// <param name="x2">Second point x-coordinate.</param>
        /// <param name="y2">Second point y-coordinate.</param>
        /// <returns>Distance between given 2D points.</returns>
        public static double CalculateDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        /// <summary>
        /// Calculates distance between two points in the 3D Euclidean space.
        /// </summary>
        /// <param name="x1">First point x-coordinate.</param>
        /// <param name="y1">First point y-coordinate.</param>
        /// <param name="z1">First point z-coordinate.</param>
        /// <param name="x2">Second point x-coordinate.</param>
        /// <param name="y2">Second point y-coordinate.</param>
        /// <param name="z2">Second point z-coordinate.</param>
        /// <returns>Distance between given 3D points.</returns>
        public static double CalculateDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        /// <summary>
        /// Calculates the volume of Parallelepiped/Cube by given width, height and depth.
        /// </summary>
        /// <param name="width">Width of Parallelepiped.</param>
        /// <param name="height">Height of Parallelepiped.</param>
        /// <param name="depth">Depth of Parallelepiped.</param>
        /// <returns>Volume of Parallelepiped.</returns>
        public static double CalculateVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }

        /// <summary>
        /// Returns the distance from a given 2D point (x, y) to the origin O(0, 0).
        /// </summary>
        /// <param name="x">The x-coordinate of the point.</param>
        /// <param name="y">The y-coordinate of the point.</param>
        /// <returns>The distance.</returns>
        public static double CalculateDiagonal2D(double sideA, double sideB)
        {
            double distance = CalculateDistance2D(0, 0, sideA, sideB);
            return distance;
        }

        /// <summary>
        /// Returns the distance from a given 3D point (x, y, z) to the origin O(0, 0, 0).
        /// </summary>
        /// <param name="x">The x-coordinate of the point.</param>
        /// <param name="y">The y-coordinate of the point.</param>
        /// <param name="z">The z-coordinate of the point.</param>
        /// <returns>The distance.</returns>
        public static double CalculateDiagonal3D(double width, double height, double depth)
        {
            double distance = CalculateDistance3D(0, 0, 0, width, height, depth);
            return distance;
        }


    }
}
