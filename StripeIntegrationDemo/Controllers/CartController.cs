namespace StripeIntegrationDemo.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Stripe;
    using StripeIntegrationDemo.Models;

    public class CartController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Pay()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Pay(PaymentIntentCreateRequest request)
        {
            var paymentIntents = new PaymentIntentService();
            var paymentIntent = await paymentIntents.CreateAsync(new PaymentIntentCreateOptions
            {
                Amount = this.CalculateOrderAmount(request.Items),
                Currency = "usd",
            });

            return this.Json(new { clientSecret = paymentIntent.ClientSecret });
        }

        private int CalculateOrderAmount(Item[] items)
        {
            // Replace this constant with a calculation of the order's amount
            // Calculate the order total on the server to prevent
            // people from directly manipulating the amount on the client
            return 1400;
        }
    }
}