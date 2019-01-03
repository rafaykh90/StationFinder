using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NordCTask.Models
{
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
