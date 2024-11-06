namespace ApiWeather.Entitites
{
    public class City
    {
        public int cityId { get; set; }
        public string cityName{ get; set; }
        public decimal temp { get; set; }
        public string detail { get; set; }
        public string country { get; set; }
    }
}
