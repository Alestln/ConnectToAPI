using System.Text.Json.Serialization;

namespace TestProject.WeatherClasses;

public class Coord
{
    [JsonPropertyName("lon")]
    public double Lon { get; set; }

    [JsonPropertyName("lat")]
    public double Lat { get; set; }
}