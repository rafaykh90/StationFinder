using System;

namespace NordCTask.Models
{
	public class Point
	{
		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}

		public double X { get; private set; }
		public double Y { get; private set; }

		public double CalculateDistanceFrom(Point point)
		{
			double a = X - point.X;
			double b = Y - point.Y;
			return Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), 4);
		}
	}
}
