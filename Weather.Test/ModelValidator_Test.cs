using FluentAssertions;
using Newtonsoft.Json.Schema.Generation;
using NUnit.Framework;
using Weather.Model;
using Weather.MVC.Models;

namespace Weather.Test
{
	[TestFixture]
	public class ModelValidator_Test
	{
		[Test]
		public void ModelsAreCompatible()
		{
			var generator = new JSchemaGenerator();
			var modelSchema = generator.Generate(typeof(WeatherForecast));
			var viewModelSchema = generator.Generate(typeof(WeatherViewModel));
			var s1 = modelSchema.ToString();
			var s2 = viewModelSchema.ToString();
			s1.Should().Be(s2);
		}
	}
}
