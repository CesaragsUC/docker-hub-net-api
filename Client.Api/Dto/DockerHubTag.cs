namespace ObterRepositorioDockerHub.Dto;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public record DockerHubTag
{
    [JsonPropertyName("creator")]
    public int? Creator { get; set; }

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("images")]
    public List<DockerHubImage>? Images { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; set; }

    [JsonPropertyName("last_updater_username")]
    public string? LastUpdaterUsername { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("repository")]
    public int? Repository { get; set; }

    [JsonPropertyName("full_size")]
    public long? FullSize { get; set; }

    [JsonPropertyName("v2")]
    public bool V2 { get; set; }

    [JsonPropertyName("tag_status")]
    public string? TagStatus { get; set; }

    [JsonPropertyName("tag_last_pulled")]
    public DateTime? TagLastPulled { get; set; }

    [JsonPropertyName("tag_last_pushed")]
    public DateTime? TagLastPushed { get; set; }

    [JsonPropertyName("media_type")]
    public string? MediaType { get; set; }

    [JsonPropertyName("content_type")]
    public string? ContentType { get; set; }

    [JsonPropertyName("digest")]
    public string? Digest { get; set; }
}
