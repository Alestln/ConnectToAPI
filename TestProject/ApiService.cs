namespace TestProject;

public class ApiService
{
    private readonly HttpClient _httpClient = new();
    private readonly string _apiKey = "4c8506c9573f1be4fe0f2490d76c4a6c";

    public async Task<string> GetDataAsync(string city)
    {
        string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}";
        
        HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadAsStringAsync();
        }
        
        throw new Exception($"Failed to retrieve data from the API. Status code: {response.StatusCode}");
    }
}