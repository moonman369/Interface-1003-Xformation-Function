using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Primark1003.Function
{
    public class XML_Enrichment_0
    {
        private readonly ILogger<XML_Enrichment_0> _logger;

        public XML_Enrichment_0(ILogger<XML_Enrichment_0> logger)
        {
            _logger = logger;
        }

        [Function("XML_Enrichment_0")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            if (req.Method == "GET")
            {
                return new HttpResponseMessage { Content = new StringContent("USE POST METHOD FOR XFORMATION") };
            }
            return new HttpResponseMessage
            {
                Content = new StringContent("Good")
            };
        }
    }
}
