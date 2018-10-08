using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CarrierEnum : byte
    {
        /// <summary>
        /// олько по Wi-FI
        /// </summary>
        WI_FI_ONLY,
        /// <summary>
        /// по мобильной связи и Wi-Fi
        /// </summary>
        WI_FI_AND_CELLULAR
    }
}
