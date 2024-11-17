namespace ObterRepositorioDockerHub.Dto;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public record DockerHubRepository
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("repository_type")]
    public string? RepositoryType { get; set; }

    [JsonPropertyName("status")]
    public int? Status { get; set; }

    [JsonPropertyName("status_description")]
    public string? StatusDescription { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("is_private")]
    public bool IsPrivate { get; set; }

    [JsonPropertyName("star_count")]
    public int? StarCount { get; set; }

    [JsonPropertyName("pull_count")]
    public int? PullCount { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; set; }

    [JsonPropertyName("last_modified")]
    public DateTime? LastModified { get; set; }

    [JsonPropertyName("date_registered")]
    public DateTime? DateRegistered { get; set; }

    [JsonPropertyName("affiliation")]
    public string? Affiliation { get; set; }

    [JsonPropertyName("media_types")]
    public List<string>? MediaTypes { get; set; }

    [JsonPropertyName("content_types")]
    public List<string>? ContentTypes { get; set; }

    [JsonPropertyName("categories")]
    public List<string>? Categories { get; set; }

    [JsonPropertyName("storage_size")]
    public long? StorageSize { get; set; }
}