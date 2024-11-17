namespace ObterRepositorioDockerHub.Services;

using Microsoft.Extensions.Options;
using ObterRepositorioDockerHub.Configurations;
using ObterRepositorioDockerHub.Dto;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

public interface IDockerHubService
{
    Task<DockerHubTagsResponse> GetRepositoriesWithTagAsync(string imageName);
    Task<DockerHubRepositoriesResponse> GetRepositoriesAsync();

}

public class DockerHubService : IDockerHubService
{
    private readonly HttpClient _httpClient;
    private readonly DockerHubSettings _settings;

    public DockerHubService(HttpClient httpClient, IOptions<DockerHubSettings> options)
    {
        _httpClient = httpClient;
        _settings = options.Value;
    }

    public async Task<DockerHubTagsResponse> GetRepositoriesWithTagAsync(string imageName)
    {
        var url = $"{_settings.BaseUrl}/{_settings.Namespace}/{imageName}/{_settings.TagsEndpoint}";

        var token = await GetAuthTokenAsync(_settings.Username!, _settings.Password!);

        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("JWT", token);

        var response = await _httpClient.GetAsync(url);

        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<DockerHubTagsResponse>(responseContent);
    }

    public async Task<DockerHubRepositoriesResponse> GetRepositoriesAsync()
    {
        var url = $"{_settings.BaseUrl}/{_settings.Namespace}";

        var token = await GetAuthTokenAsync(_settings.Username!, _settings.Password!);

        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("JWT", token);

        var response = await _httpClient.GetAsync(url);

        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<DockerHubRepositoriesResponse>(responseContent);
    }

    private async Task<string> GetAuthTokenAsync(string username, string password)
    {
        var credentials = new
        {
            username = username,
            password = password
        };

        var content = new StringContent(
            JsonSerializer.Serialize(credentials),
            Encoding.UTF8,
            "application/json"
        );

        var response = await _httpClient.PostAsync(_settings.LoginUrl, content);
        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();
        var authResponse = JsonSerializer.Deserialize<DockerHubAuthResponse>(responseContent);

        return authResponse?.Token;
    }
}
