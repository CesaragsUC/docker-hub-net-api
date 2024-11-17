using System.Text.Json.Serialization;

namespace ObterRepositorioDockerHub.Dto;

public class DockerHubAuthResponse
{
    [JsonPropertyName("token")]
    public string? Token { get; set; }
}
