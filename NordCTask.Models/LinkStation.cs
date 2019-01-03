using System;

namespace NordCTask.Models
{
	public class LinkStation
	{
		public Point Location { get; private set; }
		public double Reach { get; private set; }

		public LinkStation(Point loc, double reach)
		{
			Location = loc;
			Reach = reach;
		}

		public double CalculatePowerFrom(Point p)
		{
			var distance = Location.CalculateDistanceFrom(p);
			if(distance > Reach)
			{
				return 0;
			}
			return Math.Round(Math.Pow(Reach - distance, 2), 4);
		}

	}
}
