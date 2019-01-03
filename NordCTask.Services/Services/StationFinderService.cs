using NordCTask.Models;
using NordCTask.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NordCTask.Services
{
	/// <summary>
	/// This service finds the most suitable station for a device location. Implements IStationFinderService.
	/// </summary>
	public class StationFinderService : IStationFinderService
	{
		private readonly List<LinkStation> LinkStations;

		public StationFinderService()
		{
			//Pre-defined Station location and reach. 
			//A repository can be used to load this data dynamically(Not used in this project for simplicity)
			LinkStations = new List<LinkStation>()
			{
				new LinkStation(loc: new Point(0, 0), reach: 10),
				new LinkStation(loc: new Point(20, 20), reach: 5),
				new LinkStation(loc: new Point(10, 0), reach: 12)
			};
		}

		/// <summary>
		/// Calculated and creates a list for the device location provided and the List of station created in the constructor of this class
		/// </summary>
		/// <param name="deviceLocation">Point (x, y) for device location</param>
		/// <returns>List of performed calculation results between point and stations</returns>
		public List<DeviceStationData> CalculateValuesForDeviceToStation(Point deviceLocation)
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
