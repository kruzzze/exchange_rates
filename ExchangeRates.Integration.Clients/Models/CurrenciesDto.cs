using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ExchangeRates.Integration.Clients.Models
{
    /// <summary>
    ///     Dto with specific data about currencies rate
    /// </summary>
    public class CurrenciesDto
    {
        [JsonProperty("base")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Currency BaseCurrency { get; set; }

        [JsonProperty("rates")]
        public IDictionary<Currency, decimal> Rates { get; set; }

        [JsonProperty("date")]
        public DateTime CurrentDate { get; set; }
    }
}