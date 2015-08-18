namespace Matrix
{
    /// <summary>
    /// The Point class.
    /// </summary>
    internal class Point
    {
        /// <summary>
        /// Initializes a new instance of class <see cref="Point"/>.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// The x coordinate.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// The y coordinate.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Sums two points.
        /// </summary>
        /// <param name="firstPoint">The first point.</param>
        /// <param name="secondPoint">The second point.</param>
        /// <returns>Returns a new result point from the sum of the both points.</returns>
        public static Point operator +(Point firstPoint, Point secondPoint)
        {
            return new Point(firstPoint.X + secondPoint.X, firstPoint.Y + secondPoint.Y);
        }
    }
}