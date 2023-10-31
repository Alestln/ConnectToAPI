using System.Text.Json.Serialization;

namespace TestProject.WeatherClasses;

public class Clouds
{
    [JsonPropertyName("all")]
    public int All { get; set; }
}