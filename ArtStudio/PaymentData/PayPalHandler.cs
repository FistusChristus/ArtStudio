using PayPal.Api;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace ArtStudio.PaymentData
{
    class PayPalHandler
    {
        private readonly Dictionary<string, string> _payPalConfig;

        public Dictionary<string,string> getPayPalConfig()
        {
            return _payPalConfig;
        }
        public PayPalHandler(IConfiguration config)
        {
             _payPalConfig = new Dictionary<string, string>()
            {
                { "clientId" , config.GetSection("paypal:settings:clientId").Value },
                { "clientSecret", config.GetSection("paypal:settings:clientSecret").Value },
                { "mode", config.GetSection("paypal:settings:mode").Value },
                { "connectionTimeout", config.GetSection("paypal:settings:connectionTimeout").Value },
                { "requestRetries", config.GetSection("paypal:settings:requestRetries").Value },
                { "business", config.GetSection("paypal:settings:business").Value },
            };
        }
    }
}
