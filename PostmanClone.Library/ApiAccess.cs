﻿using System.Text;
using System.Text.Json;

namespace PostmanClone.Library
{
    public class ApiAccess : IApiAccess
    {
        private readonly HttpClient _httpClient = new();

        public async Task<string> CallApiAsync(
            string url,
            string content,
            HttpAction action = HttpAction.GET,
            bool formatOutput = true
        )
        {
            StringContent stringContent = new (content, Encoding.UTF8, "application/json");
            return await CallApiAsync(url, stringContent, action, formatOutput);
        }

        public async Task<string> CallApiAsync(
            string url,
            HttpContent? content = null,
            HttpAction action = HttpAction.GET,
            bool formatOutput = true
        )
        {
            HttpResponseMessage? response;

            switch (action)
            {
                case HttpAction.GET:
                    response = await _httpClient.GetAsync(url);
                    break;

                case HttpAction.POST:
                    response = await _httpClient.PostAsync(url, content);
                    break;

                case HttpAction.PUT:
                    response = await _httpClient.PutAsync(url, content);
                    break;

                case HttpAction.PATCH:
                    response = await _httpClient.PatchAsync(url, content);
                    break;

                case HttpAction.DELETE:
                    response = await _httpClient.DeleteAsync(url);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(action), action, null);
            }

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                if (formatOutput)
                {
                    var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                    JsonSerializerOptions jsonSerializerOptions = new()
                    {
                        WriteIndented = true
                    };

                    json = JsonSerializer.Serialize(jsonElement, jsonSerializerOptions);
                }

                return json;
            }

            return $"Error: {response.StatusCode}";
        }

        public bool IsValidUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return false;
            }

            bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput) && uriOutput.Scheme == Uri.UriSchemeHttps;

            return output;
        }
    }
}
