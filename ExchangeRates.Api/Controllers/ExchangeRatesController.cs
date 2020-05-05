using System.Threading.Tasks;
using ExchangeRates.Integration.Clients;
using ExchangeRates.Integration.Clients.Models;
using Microsoft.AspNetCore.Mvc;

namespace Currencies.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRatesController : ControllerBase
    {
        private readonly ICurrenciesClient _currenciesClient;

        public ExchangeRatesController(ICurrenciesClient currenciesClient)
        {
            _currenciesClient = currenciesClient;
        }

        [HttpGet("getExchangeRates")]
        public async Task<CurrenciesDto> GetExchangeRates()
        {
            return await _currenciesClient.GetCurrenciesRateWithCustomBase(Currency.RUB.ToString());
        }
    }
}