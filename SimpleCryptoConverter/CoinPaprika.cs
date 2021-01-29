using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SimpleCryptoConverter
{
    public static class CoinPaprika
    {
        private const string ApiUrl = "https://api.coinpaprika.com/v1";

        public static async Task<string> Convert(string baseCurrencyId, string quoteCurrencyId, double amount)
        {
            var url = (ApiUrl + "/price-converter").AddParameterToUrl("base_currency_id", baseCurrencyId.ToLower())
                .AddParameterToUrl("quote_currency_id", quoteCurrencyId.ToLower()).AddParameterToUrl("amount", amount).Replace(',','.');

            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            
            var client = new HttpClient();
            var responseBody = await client.GetStringAsync(url);

            return JObject.Parse(responseBody)["price"]?.ToString();
        }

        public static async Task<string> GetCoinInfo(string coinTitle, string coinName)
        {
            var url = $"{ApiUrl}/ticker/{coinTitle.ToLower()}-{coinName.ToLower()}";
            
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            var client = new HttpClient();
            var responseBody = await client.GetStringAsync(url);
            
            var currentPrice = (JObject.Parse(responseBody)["price_usd"]).Value<double>();
            return currentPrice.ToString("F");
        }
 
        public static string AddParameterToUrl(this string url, string parameterName, object parameterValue)
        {
            return url.Contains("?") ? url + "&" + parameterName + "=" + parameterValue : url + "?" + parameterName + "=" + parameterValue;
        }
    }
}