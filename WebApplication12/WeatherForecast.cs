namespace WebApplication12
{
    public class WeatherForecast
    {
        public DateTime Date { get; 
            //123
            set; }

        public int TemperatureC { get; set; }
        //123123
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}