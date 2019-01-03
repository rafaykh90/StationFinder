using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NordCTask.Models;
using NordCTask.ServiceInterfaces;
using NordCTask.Services;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace NordCTask.Test.Integration
{
	public class StationFinderServiceTest
	{
		private readonly ITestOutputHelper output;
		private ILogger _logger;
		private readonly IStationFinderService _stationFinderService;

		public StationFinderServiceTest(ITestOutputHelper output)
		{
			this.output = output;

			var services = new ServiceCollection()
				  .AddLogging((builder) => builder.AddXUnit(output));
			services.AddSingleton<IStationFinderService, StationFinderService>();

			var provider = services.BuildServiceProvider();
			_logger = provider.GetService<ILogger<StationFinderServiceTest>>();
			_stationFinderService = provider.GetService<IStationFinderService>();
		}

		[Theory]
		[InlineData(0, 0, 100)]
		[InlineData(100, 100, 0)]
		[InlineData(15, 10, 0.6719)]
		[InlineData(18, 18, 4.7158)]
		public void TestFindSuitableStation(double x, double y, double expectedPower)
		{
			_logger.LogInformation("Starting test");
			var res = _stationFinderService.FindSuitableStation(new Point(x, y));
			var suitableStation = res.OrderByDescending(ds => ds.Power).FirstOrDefault();
			Assert.Equal(expectedPower, suitableStation.Power);
			_logger.LogInformation("Successfull");
		}
	}
}
