using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CampaignStatusPaymentEnum : byte
    {
        DISALLOWED,
        ALLOWED
    }
}
