using ApiWeather.Context;
using ApiWeather.Entitites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        WeatherContext context = new WeatherContext();

        [HttpGet]
        public IActionResult WeatherCityList()
        {
            var values = context.Cities.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateWeatherCity(City city)
        {
            context.Cities.Add(city);
            context.SaveChanges();
            return Ok("Şehir Eklend");
        }

        [HttpDelete]
        public IActionResult DeleteWeatherCity(int cityId)
        {
            var value = context.Cities.Find(cityId);
            context.Cities.Remove(value);
            context.SaveChanges();
            return Ok("Şehir silindi");
        }

        [HttpPut]
        public IActionResult PutWeatherCity(City city)
        {
            var value = context.Cities.Find(city.cityId);
            value.cityName = city.cityName;
            value.detail = city.detail;
            value.temp = city.temp;
            value.country = city.country;
            context.SaveChanges();
            return Ok("Şehir Güncellendi");
        }

        [HttpGet("GetByIdWeatherCity")]
        public IActionResult GetByIdWeatherCity(int cityId)
        {
            var value = context.Cities.Find(cityId);
            return Ok(value);
        }

        [HttpGet("TotalCityCount")]
        public IActionResult TotalCityCount()
        {
            var value = context.Cities.Count();
            return Ok(value);
        }

        [HttpGet ("MaxTemplateCityName")]

        public IActionResult MaxTemplateCityName()
        {
            var value= context.Cities.OrderByDescending(x => x.temp).Select(y=>y.cityName).FirstOrDefault();
            return Ok(value);
        }


    }
}
