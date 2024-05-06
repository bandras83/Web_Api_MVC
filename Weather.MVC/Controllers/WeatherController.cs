using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Weather.MVC.Models;

namespace Weather.MVC.Controllers
{
	public class WeatherController : Controller
	{
		private Uri _baseAddress = new Uri("https://localhost:7183");
		private HttpClient _httpClient;

        public WeatherController()
        {
            _httpClient = new HttpClient();
			_httpClient.BaseAddress = _baseAddress;
        }

        [HttpGet]
		public IActionResult Index()
		{
			var weatherList = new List<WeatherViewModel>();
			var response = _httpClient.GetAsync(_httpClient.BaseAddress + "WeatherForecast/Get").Result;
			if (response.IsSuccessStatusCode)
			{
				var responseString = response.Content.ReadAsStringAsync().Result;
				weatherList = JsonConvert.DeserializeObject<List<WeatherViewModel>>(responseString);
			}

			return View(weatherList);
		}
	}
}
