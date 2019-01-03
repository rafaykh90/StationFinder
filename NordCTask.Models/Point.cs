using System;

namespace NordCTask.Models
{
	/// <summary>
	/// Simple Point class containing X and Y values.
	/// </summary>
	public class Point
	{
		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}

		public double X { get; private set; }
		public double Y { get; private set; }

		/// <summary>
		/// This method calculates the distance using the distance formula between the provided point and the instance point (self)
		/// </summary>
		/// <param name="point">Point from which the distance is to be calculated</param>
		/// <returns>Distance value</returns>
		public double CalculateDistanceFrom(Point point)
		{
			double a = X - point.X;
			double b = Y - point.Y;
			return Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), 4); //Round the value to 4 decimal values
		}
	}
}
