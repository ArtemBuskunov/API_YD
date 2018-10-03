using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    /// <summary>
    /// Справочник валют
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CurrencyEnum { RUB, BYN, CHF, EUR, KZT, TRY, UAH, USD, YND_FIXED }
}
