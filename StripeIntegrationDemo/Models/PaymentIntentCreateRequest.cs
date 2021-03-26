namespace StripeIntegrationDemo.Models
{
    using Newtonsoft.Json;

    public class PaymentIntentCreateRequest
    {
        [JsonProperty("items")]
        public Item[] Items { get; set; }
    }
}