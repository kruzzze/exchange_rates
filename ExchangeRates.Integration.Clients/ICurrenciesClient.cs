using System.Threading.Tasks;
using ExchangeRates.Integration.Clients.Models;
using Refit;

namespace ExchangeRates.Integration.Clients
{
    //            var currenciesApi = RestService.For<ICurrenciesClient>("https://api.ratesapi.io/");
    public interface ICurrenciesClient
    {
        [Get("/api/latest")]
        Task<CurrenciesDto> GetCurrenciesRate();

        [Get("/api/latest?base={currency}")]
        Task<CurrenciesDto> GetCurrenciesRateWithCustomBase([AliasAs("currency")] string currencyName);
    }
}