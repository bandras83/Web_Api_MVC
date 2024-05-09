using AutoMapper;
using NUnit.Framework;
using Weather.MVC.Mapping;

namespace Weather.Test
{
	[TestFixture]
	public class ModelValidator_Test
	{
		[Test]
		public void ModelsAreCompatible()
		{
			var mapper = new MapperConfiguration(cfg => cfg.AddProfile<WeatherMappingProfile>()).CreateMapper();
			mapper.ConfigurationProvider.AssertConfigurationIsValid();
		}
	}
}
