using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NordCTask.Models;
using NordCTask.ServiceInterfaces;

namespace NordCTask.Controllers
{
	[Route("api/[controller]")]
	public class StationsController : Controller
    {
		private readonly ILogger _logger;
		private readonly IStationFinderService _stationFinderService;

		public StationsController(IStationFinderService stationFinderService, ILogger<StationsController> logger)
		{
			_logger = logger;
			_stationFinderService = stationFinderService;
		}

		[HttpGet]
		public IActionResult GetStations([FromQuery] QueryParameters query)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest();
			}
			return Ok(_stationFinderService.CalculateValuesForDeviceToStation(new Point(query.X, query.Y)));
		}
	}

	public class QueryParameters
	{
		[Required]
		public double X { get; set; }

		[Required]
		public double Y { get; set; }
	}
}