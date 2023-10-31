using System.Text.Json;
using TestProject;
using TestProject.WeatherClasses;

internal class Program
{
    public static async Task Main(string[] args)
    {
        string city = "London";

        ApiService apiService = new ApiService();
        ThreadManager threadManager = new ThreadManager();

        string data = await threadManager.DownloadDataInThreadAsync(apiService, city);

        Console.WriteLine(data);
        
        Root root = JsonSerializer.Deserialize<Root>(data);
    }
}