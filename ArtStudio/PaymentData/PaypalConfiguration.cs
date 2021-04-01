using Microsoft.Extensions.Configuration;
using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStudio.PaymentData
{
    public static class PaypalConfiguration
    {
        //Variables for storing the clientID and clientSecret key  
        public readonly static string ClientId;
        public readonly static string ClientSecret;
        public static IConfiguration configuration { get; set; }
        //Constructor  
        static PaypalConfiguration()
        {
            configuration = Data.Extensions.GetConfiguration();
            var config = GetConfig();
            ClientId = config["clientId"];
            ClientSecret = config["clientSecret"];
        }
        // getting properties from the web.config
        public static Dictionary<string, string> GetConfig()
        {
            var handler = new PayPalHandler(configuration);
            Dictionary<string, string> Config = handler.getPayPalConfig();
            
            return Config;
        }
        private static string GetAccessToken()
        {
            // getting accesstocken from paypal  
            var payPalConfig = new PayPalHandler(configuration);
            var conf = payPalConfig.getPayPalConfig();
            var accessToken = new OAuthTokenCredential(conf).GetAccessToken();
            return accessToken;
        }
        public static APIContext GetAPIContext()
        {
            // return apicontext object by invoking it with the accesstoken  
            APIContext apiContext = new APIContext(GetAccessToken());
            apiContext.Config = GetConfig();
            return apiContext;
        }
    }
}
