namespace StripeIntegrationDemo.Models
{
    using Newtonsoft.Json;

    public class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}