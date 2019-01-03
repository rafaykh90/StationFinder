using Newtonsoft.Json;
using NordCTask.Models;
using System.Collections.Generic;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace NordCTask.Test.Unit
{
	public class CalculationsTest
	{
		private readonly ITestOutputHelper output;

		public CalculationsTest(ITestOutputHelper output)
		{
			this.output = output;
		}

		[Fact]
		public void TestCalculateDistance()
		{
			//Arrange
			List<TestDistanceDataObject> testCases = JsonConvert.DeserializeObject<List<TestDistanceDataObject>>(File.ReadAllText(@"Unit/TestData.json"));

			foreach (var tCase in testCases)
			{
				//Act
				var distance = tCase.p1.CalculateDistanceFrom(tCase.p2);

				//Assert
				Assert.Equal(tCase.expectedValue, distance);
			}
		}

		[Fact]
		public void TestCalculatePower()
		{
			//Arrange
			var station = new LinkStation(new Point(18, 18), 10);
			var p1 = new Point(15, 10);

			//Act
			var power = station.CalculatePowerFrom(p1);

			//Assert
			Assert.Equal(2.1199, power);

			//Arrange
			station = new LinkStation(new Point(0, 0), 10);

			//Act
			power = station.CalculatePowerFrom(p1);

			//Assert
			Assert.Equal(0, power);
		}

		[Fact]
		public void TestDeviceStationData()
		{
			var dsd = new DeviceStationData(new LinkStation(new Point(10, 15), 20), new Point(3, 4));
			output.WriteLine(JsonConvert.SerializeObject(dsd, Formatting.Indented));
		}
	}

	public class TestDistanceDataObject
	{
		public double expectedValue { get; set; }
		public Point p1 { get; set; }
		public Point p2 { get; set; }
	}
}