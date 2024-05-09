using AutoMapper;
using Weather.Model;
using Weather.MVC.Models;

namespace Weather.MVC.Mapping
{
	public class WeatherMappingProfile : Profile
	{
		public WeatherMappingProfile()
		{
			CreateMap<WeatherForecast, WeatherViewModel>();
		}
	}
}
