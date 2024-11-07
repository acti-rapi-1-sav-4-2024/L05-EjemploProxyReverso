namespace EjemploProxyReverso;

public class PoetryService : IPoetryService
{
    private readonly HttpClient _httpClient;


    public PoetryService(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("PoetryAPI");
    }

    public async Task<string> GetAuthorsAsync()
    {
        
        var responseString = await _httpClient.GetStringAsync("author");
        
        
        Console.WriteLine(responseString);

        return responseString;
    }
    
}