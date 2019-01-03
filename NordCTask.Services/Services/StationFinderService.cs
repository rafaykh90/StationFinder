using NordCTask.Models;
using NordCTask.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NordCTask.Services
{
	public class StationFinderService : IStationFinderService
	{
		private readonly List<LinkStation> LinkStations;

		public StationFinderService()
		{
			LinkStations = new List<LinkStation>()
			{
				new LinkStation(loc: new Point(0, 0), reach: 10),
				new LinkStation(loc: new Point(20, 20), reach: 5),
				new LinkStation(loc: new Point(10, 0), reach: 12)
			};
		}

		public List<DeviceStationData> FindSuitableStation(Point deviceLocation)
		{
			var deviceToStationData = new List<DeviceStationData>();
			foreach (var station in LinkStations)
			{
				deviceToStationData.Add(new DeviceStationData(station, deviceLocation));
			}
			return deviceToStationData;
		}
	}
}
