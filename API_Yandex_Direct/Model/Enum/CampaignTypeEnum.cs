using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CampaignTypeEnum : byte
    {
        TEXT_CAMPAIGN,
        MOBILE_APP_CAMPAIGN,
        DYNAMIC_TEXT_CAMPAIGN
    }
}
