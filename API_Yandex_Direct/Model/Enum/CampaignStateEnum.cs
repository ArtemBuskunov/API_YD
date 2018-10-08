using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CampaignStateEnum : byte
    {
        CONVERTED,
        ARCHIVED,
        SUSPENDED,
        ENDED,
        ON,
        OFF,
        UNKNOWN
    }
}
