namespace ObterRepositorioDockerHub.Dto;

using System.Collections.Generic;
using System.Text.Json.Serialization;

public record DockerHubTagsResponse
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("next")]
    public string Next { get; set; }

    [JsonPropertyName("previous")]
    public string Previous { get; set; }

    [JsonPropertyName("results")]
    public List<DockerHubTag>? Results { get; set; }
}
