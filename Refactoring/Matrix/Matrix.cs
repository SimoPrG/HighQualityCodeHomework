namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The Matrix class.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// All directions in the matrix.
        /// </summary>
        private readonly List<Point> directions =
            new List<Point>
            {
                new Point(1, 1),    // down right
                new Point(1, 0),    // down
                new Point(1, -1),   // down left
                new Point(0, -1),   // left
                new Point(-1, -1),  // up left
                new Point(-1, 0),   // up
                new Point(-1, 1),   // up right
                new Point(0, 1)     // right
            };

        /// <summary>
        /// The matrix.
        /// </summary>
        private readonly int[,] matrix;

        /// <summary>
        /// The current direction index in the matrix.
        /// </summary>
        private int currentDirectionIndex;

        /// <summary>
        /// Initializes a new instance of class <see cref="Matrix"/>.
        /// </summary>
        /// <param name="size">The size of the matrix.</param>
        public Matrix(int size)
        {
            if (size < 1)
            {
                throw new ArgumentException("Input value should be more than 1.");
            }

            this.matrix = new int[size, size];
            this.currentDirectionIndex = 0;
            this.FillMatrixValues();
        }

        /// <summary>
        /// The fill matrix values.
        /// </summary>
        private void FillMatrixValues()
        {
            var currentPosition = new Point(0, 0);
            var currentWriteValue = 1;

            do
            {
                this.matrix[currentPosition.X, currentPosition.Y] = currentWriteValue;
                currentPosition = this.Move(currentPosition) ?? this.GetFirstFreeCell();
                currentWriteValue++;
            }
            while (currentPosition != null);
        }

        /// <summary>
        /// Moves the point in the matrix.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>Returns a point with new coordinates in the matrix.</returns>
        private Point Move(Point point)
        {
            for (var i = this.currentDirectionIndex; i < this.directions.Count + this.currentDirectionIndex; i++)
            {
                var newPoint = point + this.directions[i % this.directions.Count];
                if (this.IsPointInMatrixRange(newPoint) && (this.matrix[newPoint.X, newPoint.Y] == 0))
                {
                    this.currentDirectionIndex = i % this.directions.Count;
                    return newPoint;
                }
            }

            return null;
        }

        /// <summary>
        /// Checks is the point in matrix range.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>Returns true if the point is in the range of the matrix.</returns>
        private bool IsPointInMatrixRange(Point point)
        {
            var isPointInXRange = point.X >= 0 && point.X < this.matrix.GetLength(0);
            var isPointInYRange = point.Y >= 0 && point.Y < this.matrix.GetLength(0);

            return isPointInXRange && isPointInYRange;
        }

        /// <summary>
        /// Gets the first free cell of the matrix.
        /// </summary>
        /// <returns>Returns a first free point from the matrix.</returns>
        private Point GetFirstFreeCell()
        {
            var point = new Point(0, 0);
            for (var row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (var column = 0; column < this.matrix.GetLength(0); column++)
                {
                    if (this.matrix[row, column] == 0)
                    {
                        point.X = row;
                        point.Y = column;
                        this.currentDirectionIndex = 0;

                        return point;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Converts a matrix to string.
        /// </summary>
        /// <returns>Returns a matrix as a string.</returns>
        public override string ToString()
        {
            var result = new StringBuilder();

            for (var row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (var column = 0; column < this.matrix.GetLength(0); column++)
                {
                    result.Append(string.Format("{0,3}", this.matrix[row, column]));
                }

                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }
    }
}