using System.Text.Json.Serialization;

namespace Phamquangha_2122110195_1.Model
{
    public class Login
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
