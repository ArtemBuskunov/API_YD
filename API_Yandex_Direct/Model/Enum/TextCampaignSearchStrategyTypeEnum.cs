using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextCampaignSearchStrategyTypeEnum
    {
        HIGHEST_POSITION,
        IMPRESSIONS_BELOW_SEARCH,
        WB_MAXIMUM_CLICKS,
        WB_MAXIMUM_CONVERSION_RATE,
        AVERAGE_CPC,
        AVERAGE_CPA,
        AVERAGE_ROI,
        WEEKLY_CLICK_PACKAGE,
        SERVING_OFF
    }
}
