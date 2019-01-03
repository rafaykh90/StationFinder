using NordCTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NordCTask.ServiceInterfaces
{
	/// <summary>
	/// Use this Interface to implement IoC. 
	/// This is used for DI in this project
	/// </summary>
	public interface IStationFinderService
	{
		List<DeviceStationData> CalculateValuesForDeviceToStation(Point p);
	}
}
