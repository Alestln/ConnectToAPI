using System.Text.Json;
using TestProject.WeatherClasses;

namespace TestProject;

public class ThreadManager
{
    public async Task<string> DownloadDataInThreadAsync(ApiService apiService, string city)
    {
        return await Task.Run(async () =>
        {
            try
            {
                string data = await apiService.GetDataAsync(city);
                return data;
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        });
    }

    public async Task<Root> Deserealize(string data)
    {
        return await Task.Run(async () =>
        {
            return JsonSerializer.Deserialize<Root>(data);
        });
    }
}