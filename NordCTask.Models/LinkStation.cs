using System;

namespace NordCTask.Models
{
	/// <summary>
	/// Basic information of the Link Station. 
	/// Location and Reach
	/// </summary>
	public class LinkStation
	{
		/// <summary>
		/// Location is Point (x, y) which indicates the coordinates of the Link station
		/// </summary>
		public Point Location { get; private set; }

		/// <summary>
		/// This is the reach of the station. (Every station has its own reach value)
		/// </summary>
		public double Reach { get; private set; }

		public LinkStation(Point loc, double reach)
		{
			Location = loc;
			Reach = reach;
		}

		/// <summary>
		/// This method is used to calculate the power of the station based on the location of the Device.
		/// </summary>
		/// <param name="p">Device Location (x, y)</param>
		/// <returns>Power value (double)</returns>
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
