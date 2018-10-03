using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextCampaignNetworkStrategyTypeEnum
    {
        AVERAGE_CPA,
        AVERAGE_CPC,
        AVERAGE_ROI,
        MAXIMUM_COVERAGE,
        NETWORK_DEFAULT,
        SERVING_OFF,
        UNKNOWN,
        WB_MAXIMUM_CLICKS,
        WB_MAXIMUM_CONVERSION_RATE,
        WEEKLY_CLICK_PACKAGE
    }
}
