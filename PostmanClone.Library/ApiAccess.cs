using System.Text.Json;

namespace PostmanClone.Library
{
    public class ApiAccess : IApiAccess
    {
        private readonly HttpClient _httpClient = new();

        public async Task<string> CallApiAsync(
            string url,
            bool formatOutput = true,
            HttpAction action = HttpAction.GET
        )
        {
            var response = await _httpClient.GetAsync(url);

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
