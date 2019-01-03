using NordCTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NordCTask.ServiceInterfaces
{
	public interface IStationFinderService
	{
		List<DeviceStationData> FindSuitableStation(Point p);
	}
}
