namespace Figure
{
    using System;

    /// <summary>
    /// Contains figure measures and helper methods to work with this measures.
    /// </summary>
    public class Size
    {
        /// <summary>
        /// Contains the width of the figure.
        /// </summary>
        private double width; 

        /// <summary>
        /// Contains the height of the figure.
        /// </summary>
        private double height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Size"/> class.
        /// </summary>
        /// <param name="width">The width of the new figure.</param>
        /// <param name="height">The height of the new figure.</param>
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets the width size.
        /// </summary>
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        /// <summary>
        /// Gets or sets the height size.
        /// </summary>
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        /// <summary>
        /// Gets the rotated size of <paramref name="size"/>.
        /// </summary>
        /// <param name="size">The figure size to get the measures from.</param>
        /// <param name="rotationAngle">Rotation angle in radians.</param>
        /// <returns>A new instance of the <see cref="Size"/> class with the measures after rotation.</returns>
        public static Size GetRotatedSize(Size size, double rotationAngle)
        {
            double width = (Math.Abs(Math.Cos(rotationAngle)) * size.Width) + (Math.Abs(Math.Sin(rotationAngle)) * size.Height);
            double height = (Math.Abs(Math.Sin(rotationAngle)) * size.Width) + (Math.Abs(Math.Cos(rotationAngle)) * size.Height);

            return new Size(width, height);
        }
    }
}
