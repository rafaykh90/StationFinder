using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NordCTask.Models
{
	/// <summary>
	/// This class has the data which is provided to the ClientApp in the REST response
	/// Instance contains Station data (location, reach) and the device location. Based on this data the Power and Distance is calculated
	/// </summary>
	public class DeviceStationData
	{
		public LinkStation Station { get; set; }
		public double Power { get; private set; }
		public double Distance { get; private set; }

		public DeviceStationData(LinkStation station, Point deviceLocation)
		{
			Station = station;
			Power = Station.CalculatePowerFrom(deviceLocation);
			Distance = deviceLocation.CalculateDistanceFrom(Station.Location);
		}
	}
}
