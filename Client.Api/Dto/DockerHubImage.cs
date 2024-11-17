namespace ObterRepositorioDockerHub.Dto;

using System;
using System.Text.Json.Serialization;

public record DockerHubImage
{
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    [JsonPropertyName("features")]
    public string? Features { get; set; }

    [JsonPropertyName("variant")]
    public string? Variant { get; set; }

    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    [JsonPropertyName("os")]
    public string? Os { get; set; }

    [JsonPropertyName("os_features")]
    public string? OsFeatures { get; set; }

    [JsonPropertyName("os_version")]
    public string? OsVersion { get; set; }

    [JsonPropertyName("size")]
    public long? Size { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("last_pulled")]
    public DateTime? LastPulled { get; set; }

    [JsonPropertyName("last_pushed")]
    public DateTime? LastPushed { get; set; }
}
